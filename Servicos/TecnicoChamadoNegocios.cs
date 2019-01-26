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

                tecnicoChamadoColecao.Add(tecnicoChamado);
            }


            return tecnicoChamadoColecao;

        }

       /* public TecnicoChamadoRelatorioColecao ChamadoRelatorio(DateTime inicial, DateTime final, string carteira, int idTecnico, string nomeTecnico)
        {
            RBNumerosEntities et = new RBNumerosEntities();
            TecnicoChamadoRelatorioColecao tecnicoChamadoRelatorios = new TecnicoChamadoRelatorioColecao();
           
                      
           
              var  chamados = et.tblChamado.Where(c => c.Carteira == carteira &&
                                                c.DataAbertura.Year >= inicial.Year && c.DataAbertura.Month >= inicial.Month && c.DataAbertura.Day >= inicial.Day &&
                                                c.DataAbertura.Year <= final.Year && c.DataAbertura.Month <= final.Month && c.DataAbertura.Day <= final.Day).ToList();


            if (idTecnico != 0)
            {
                var ChamadosPorTecnico = chamados.Where(a => a.IdAbertoPor == idTecnico).ToList();
               

                foreach (var chamado in ChamadosPorTecnico)
                {
                    TecnicoChamadoRelatorio tecnicoChamadoRelatorio = new TecnicoChamadoRelatorio();

                    tecnicoChamadoRelatorio.NomeTecnico = nomeTecnico;
                    
                    

                }
            }
 

        }*/

            
                 

        
    }
}
