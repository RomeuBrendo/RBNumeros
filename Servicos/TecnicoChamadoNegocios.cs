using System;
using System.Linq;
using MoreLinq;
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

                tecnicoChamadoColecao.Add(tecnicoChamado);
            }


            return tecnicoChamadoColecao;

        }

        public TecnicoChamadoRelatorioColecao ChamadoRelatorio(DateTime inicial, DateTime final, string carteira)
        {
        
            RBNumerosEntities et = new RBNumerosEntities();

            TecnicoChamadoRelatorioColecao tecnicoChamadoRelatorios = new TecnicoChamadoRelatorioColecao();

            //Filtra chamados pela data
            var  chamados = et.tblChamado.Where(c => c.Carteira == carteira && 
                                                c.DataAbertura.Year >= inicial.Year && c.DataAbertura.Month >= inicial.Month && c.DataAbertura.Day >= inicial.Day &&
                                                c.DataAbertura.Year <= final.Year && c.DataAbertura.Month <= final.Month && c.DataAbertura.Day <= final.Day).ToList();

            //Realiza um Join com a tabela cliente
            var chamadosClientes = chamados.Join(et.tblCliente, chamado => chamado.IdAbertoPor, cliente => cliente.Id, (chamado, cliente) => new { chamado, cliente })
                .Where(c => c.cliente.Id == c.chamado.IdAbertoPor).Select(x => new
            {
                x.chamado.Id,
                x.chamado.IdAbertoPor,
                x.chamado.TipoChamado,
                x.chamado.Titulo,
                x.chamado.Assunto,
                x.chamado.DataAbertura,
                x.chamado.DataFechamento,             
                x.chamado.tblCliente.Nome
            }).ToList();

            //Filtra somente os tecnicos do periodo, removendo os repetidos e sem carteira
            var tecnicos = chamadosClientes.Join(et.tblTecnico, chamado => chamado.IdAbertoPor, tecnico => tecnico.Id, (chamado, tecnico) => new { chamado, tecnico }).Where(c => c.tecnico.Id == c.chamado.IdAbertoPor && c.tecnico.CarteiraSN==true).Select(x => new
            {
                x.tecnico.Id,
                x.tecnico.Nome
            }).DistinctBy(a => a.Id).ToList();

       
            //Lista é transferida para coleção
            foreach (var tecnico in tecnicos)
            {
                TecnicoChamadoRelatorio tecnicoChamadoRelatorio = new TecnicoChamadoRelatorio();
  
                tecnicoChamadoRelatorio.NomeTecnico = tecnico.Nome;
                ChamadoColecao chamadoColecao = new ChamadoColecao();

                //Coleta somente os chamados de cada tecnico
                foreach (var chamado in chamadosClientes)
                {
                    if (chamado.IdAbertoPor == tecnico.Id)
                    {

                        tblChamado chamadoNovo = new tblChamado();

                        chamadoNovo.Assunto = chamado.Assunto;
                        chamadoNovo.DataAbertura = chamado.DataAbertura;
                        chamadoNovo.DataFechamento = chamado.DataFechamento;
                        chamadoNovo.Id = chamado.Id;
                        chamadoNovo.IdAbertoPor = chamado.IdAbertoPor;
                        chamadoNovo.NomeCliente = chamado.Nome;
                        chamadoNovo.TipoChamado = chamado.TipoChamado;
                        chamadoNovo.Titulo = chamado.Titulo;

                        chamadoColecao.Add(chamadoNovo);

                        tecnicoChamadoRelatorio.Chamados = chamadoColecao;
                    }

                }           

                tecnicoChamadoRelatorios.Add(tecnicoChamadoRelatorio);
            }

            return tecnicoChamadoRelatorios;
        }

    }    
    
}
