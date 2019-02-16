using System;
using System.Linq;
using Servicos.Entidades;

namespace Servicos
{
    public class TecnicoChamadoNegocios
    {
        RBNumerosEntities et = new RBNumerosEntities();
        
        TecnicoChamadoColecao tecnicoChamadoColecao = new TecnicoChamadoColecao();

        public TecnicoChamadoColecao ConsultarChamado(DateTime inicial, DateTime final, string carteira)
        {
           var  tecnicoColecao = et.tblTecnico.Where(a => a.CarteiraSN == true && a.Carteira == carteira).ToList();

           var chamados = et.tblChamado.Where(c => c.Carteira == carteira &&
                                            c.DataAbertura.Year >= inicial.Year && c.DataAbertura.Month >= inicial.Month && c.DataAbertura.Day >= inicial.Day &&
                                            c.DataAbertura.Year <= final.Year && c.DataAbertura.Month <= final.Month && c.DataAbertura.Day <= final.Day).ToList();

            foreach (var tecnico in tecnicoColecao)
            {
                TecnicoChamado tecnicoChamado = new TecnicoChamado();

                tecnicoChamado.Id = tecnico.Id;
                tecnicoChamado.Nome = tecnico.Nome;

                tecnicoChamado.Quantidade = chamados.Count(a => a.IdAbertoPor == tecnico.Id);
                tecnicoChamado.QuantidadeRecorrente = chamados.Count(a => a.IdAbertoPor == tecnico.Id && (a.Assunto == "CHAMADO RECORRENTE"||a.Assunto == "CHAMADO PERDIDO (SEM CONTATO)" || a.TipoChamado == "RECORRENTE"));

                tecnicoChamado.Quantidade = tecnicoChamado.Quantidade - tecnicoChamado.QuantidadeRecorrente;

                tecnicoChamadoColecao.Add(tecnicoChamado);
            }

            

            return tecnicoChamadoColecao;

        }

        public TecnicoChamadoRelatorio ChamadoRelatorio(DateTime inicial, DateTime final, string carteira, int idTecnico)
        {
        
            RBNumerosEntities et = new RBNumerosEntities();

            ChamadoColecao chamadoColecao = new ChamadoColecao();

            TecnicoChamadoRelatorio tecnicoChamadoRelatorio = new TecnicoChamadoRelatorio();

            TecnicoChamadoRelatorioColecao tecnicoChamadoRelatorios = new TecnicoChamadoRelatorioColecao();

            //Filtra chamados pela data
            var  chamados = et.tblChamado.Where(c => c.Carteira == carteira && c.IdAbertoPor == idTecnico &&
                                                c.DataAbertura.Year >= inicial.Year && c.DataAbertura.Month >= inicial.Month && c.DataAbertura.Day >= inicial.Day &&
                                                c.DataAbertura.Year <= final.Year && c.DataAbertura.Month <= final.Month && c.DataAbertura.Day <= final.Day).ToList();

            //Realiza um Join com a tabela cliente
            var chamadosClientes = chamados.Join(et.tblCliente, chamado => chamado.IdCliente, cliente => cliente.Id, (chamado, cliente) => new { chamado, cliente })
                .Where(c => c.cliente.Id == c.chamado.IdCliente).Select(x => new
            {
                x.chamado.Id,
                x.chamado.IdAbertoPor,
                x.chamado.TipoChamado,
                x.chamado.Titulo,
                x.chamado.Assunto,
                x.chamado.DataAbertura,
                x.chamado.DataFechamento,             
                x.cliente.Nome,
                x.chamado.tblTecnico,
                x.cliente.Prioridade

            }).ToList();


            //chamadosClientes.RemoveAll(a => a.TipoChamado == "RECORRENTE" || a.Assunto == "CHAMADO RECORRENTE" || a.Assunto == "CHAMADO PERDIDO (SEM CONTATO)");

            foreach(var chamado in chamadosClientes)
            {
                
                
                tblChamado chamadoNovo = new tblChamado();

                chamadoNovo.Assunto = chamado.Assunto;
                chamadoNovo.DataAbertura = chamado.DataAbertura;
                chamadoNovo.DataFechamento = chamado.DataFechamento;
                chamadoNovo.Id = chamado.Id;
                chamadoNovo.IdAbertoPor = chamado.IdAbertoPor;
                chamadoNovo.NomeTecnico = chamado.tblTecnico.Nome;
                chamadoNovo.NomeCliente = chamado.Nome;
                chamadoNovo.TipoChamado = chamado.TipoChamado;
                chamadoNovo.Titulo = chamado.Titulo;

                if (chamado.Prioridade == "BAIXA")
                    tecnicoChamadoRelatorio.PrioridadeBaixa += 1;

                if (chamado.Prioridade == "MÉDIA")
                    tecnicoChamadoRelatorio.PrioridadeMedia += 1;

                if (chamado.Prioridade == "ALTA")
                    tecnicoChamadoRelatorio.PrioridadeAlta += 1;

                if (chamado.Prioridade == null)
                    tecnicoChamadoRelatorio.PrioridadeNaoDefinida += 1;

                chamadoColecao.Add(chamadoNovo);
                          
            }
            tecnicoChamadoRelatorio.Chamados = chamadoColecao;

            
           

            return tecnicoChamadoRelatorio;
        }

    }    
    
}
