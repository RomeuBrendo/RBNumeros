using System;
using System.Linq;

namespace Servicos
{
    public class ClientePrioridadeNegocio
    {
        public ChamadoColecao ChamadoPrioridade(string prioridade,string carteira,DateTime inicial, DateTime final)
        {
            RBNumerosEntities et = new RBNumerosEntities();
            ChamadoColecao chamadoColecao = new ChamadoColecao();



            var chamados = et.tblChamado.Where(c => c.Carteira == carteira && c.tblTecnico.CarteiraSN == true &&
                                                c.DataAbertura.Year >= inicial.Year && c.DataAbertura.Month >= inicial.Month && c.DataAbertura.Day >= inicial.Day &&
                                                c.DataAbertura.Year <= final.Year && c.DataAbertura.Month <= final.Month && c.DataAbertura.Day <= final.Day).ToList();

            if(prioridade!="TODOS")
             chamados = chamados.Where(a => a.tblCliente.Prioridade == prioridade).ToList();

            foreach(var chamado in chamados)
            {
                tblChamado chamadoNovo = new tblChamado();

                var tecnico = et.tblTecnico.Where(a => a.Id == chamado.IdAbertoPor).ToList();
                var cliente = et.tblCliente.Where(a => a.Id == chamado.IdCliente).ToList();

                tecnico.ForEach(a => { chamadoNovo.NomeTecnico = a.Nome; });
                cliente.ForEach(a => { chamadoNovo.NomeCliente = a.Nome; });

                chamadoNovo.Id = chamado.Id;
                chamadoNovo.IdAbertoPor = chamado.IdAbertoPor;
                chamadoNovo.NomeTecnico = chamado.tblTecnico.Nome;
              
                chamadoNovo.IdCliente = chamado.IdCliente;
                chamadoNovo.Assunto = chamado.Assunto;
                chamadoNovo.Titulo = chamado.Titulo;
                chamadoNovo.TipoChamado = chamado.TipoChamado;
                chamadoNovo.DataAbertura = chamado.DataAbertura;

                chamadoColecao.Add(chamadoNovo);
            }

            return chamadoColecao;

        }
    }
}
