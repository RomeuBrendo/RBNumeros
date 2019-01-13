using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicos.Entidades;
using Servicos;

namespace Servicos
{
    public class TecnicoChamadoNegocios
    {
        RBNumerosEntities et = new RBNumerosEntities();
        
        TecnicoChamadoColecao tecnicoChamadoColecao = new TecnicoChamadoColecao();

        //Todo..
        //Ainda falta incluir chamado perdido ou sem contato.
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
                tecnicoChamado.QuantidadeRecorrente = chamados.Count(a => a.IdAbertoPor == tecnico.Id && a.Assunto == "CHAMADO RECORRENTE");

                tecnicoChamadoColecao.Add(tecnicoChamado);
            }


            return tecnicoChamadoColecao;

        }
    }
}
