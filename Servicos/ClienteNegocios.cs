using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Servicos.Entidades;

namespace Servicos
{
    public class ClienteNegocios
    {
        
        public ClienteColecao ConsultarCliente(string carteira)
        {
            RBNumerosEntities et = new RBNumerosEntities();
            ClienteColecao clienteColecao = new ClienteColecao();

            var redes = et.tblRedeCliente.ToList();

            var clientes = new List<tblCliente>();

            if (carteira != "T")
            {
                clientes = et.tblCliente.Where(c => c.Carteira.Equals(carteira)).AsParallel().ToList();
            }
            else
            {
                 clientes = et.tblCliente.AsParallel().ToList();
            }

            clientes.ForEach(a => a.RedeNome = redes.Where(b => b.Id.Equals(a.IdRede)).Select(c => c.Nome).ToString());

            foreach(var cliente in clientes)
            {

                foreach(var rede in redes)
                {
                    if (cliente.IdRede == rede.Id)
                        cliente.RedeNome = rede.Nome;
                }
                clienteColecao.Add(cliente);
            }


            return clienteColecao;
        }

        public ClienteColecao ConsultarClienteSemPrioridade(string carteira)
        {
            RBNumerosEntities et = new RBNumerosEntities();
            ClienteColecao clienteColecao = new ClienteColecao();

            var redes = et.tblRedeCliente.ToList();

            var clientes = new List<tblCliente>();

            if (carteira != "T")
            {
                clientes = et.tblCliente.Where(c => c.Carteira.Equals(carteira) && c.Prioridade==null).AsParallel().ToList();
            }
            else
            {
                clientes = et.tblCliente.AsParallel().ToList();
            }

            clientes.ForEach(a => a.RedeNome = redes.Where(b => b.Id.Equals(a.IdRede)).Select(c => c.Nome).ToString());

            foreach (var cliente in clientes)
            {

                foreach (var rede in redes)
                {
                    if (cliente.IdRede == rede.Id)
                        cliente.RedeNome = rede.Nome;
                }
                clienteColecao.Add(cliente);
            }


            return clienteColecao;
        }

        public ChamadoColecao ConsultarChamado(string carteira)
        {
            RBNumerosEntities et = new RBNumerosEntities();
            ChamadoColecao chamadoColecao = new ChamadoColecao();

            var chamados = et.tblChamado.Where(c => c.Carteira.Equals(carteira)).ToList();

            chamados.ForEach(c => { chamadoColecao.Add(c); });

            return chamadoColecao;
        }

        public void AlteraPrioridade(int id, string prioridade)
        {
            RBNumerosEntities et = new RBNumerosEntities();

            var cliente = et.tblCliente.First(x => x.Id == id);

            cliente.Prioridade = prioridade;

            et.SaveChanges();
        }

        public void AlterarPrioridadeRede(int idRede, string carteira, string prioridade)
        {
            RBNumerosEntities et = new RBNumerosEntities();
            var clienteColecao = new List<tblCliente>();

            var cliente = et.tblCliente.Where(a => a.IdRede == idRede && a.Carteira == carteira).ToList();
                     
            cliente.ForEach(a => { a.Prioridade = prioridade; });

            et.SaveChanges();
        }

        public ClienteNRColecao ChamadosNR(string carteira, DateTime inicial, DateTime final, bool desconsiderarRecorrentes, bool desconsiderarPerdido)
        {
            RBNumerosEntities et = new RBNumerosEntities();
            ClienteNRColecao clienteNRColecao = new ClienteNRColecao();


            List<ClienteNR> chamados = new List<ClienteNR>();


          
            //Consulta os chamados separando por data.
            var chamadosAuxiliar = et.tblChamado.Where(c => c.Carteira == carteira &&  
                                                       c.DataAbertura.Year >= inicial.Year && c.DataAbertura.Month >= inicial.Month && c.DataAbertura.Day >= inicial.Day &&
                                                       c.DataAbertura.Year <= final.Year && c.DataAbertura.Month <= final.Month && c.DataAbertura.Day <= final.Day &&
                                                       c.tblTecnico.CarteiraSN==true).ToList();

            if (desconsiderarRecorrentes == false)
                chamadosAuxiliar.RemoveAll(a => a.Assunto == "CHAMADO RECORRENTE" || a.TipoChamado == "RECORRENTE");

            if (desconsiderarPerdido == false)
                chamadosAuxiliar.RemoveAll(a => a.Assunto == "CHAMADO PERDIDO (SEM CONTATO)");

            //Consulta somente os cliente da carteira
            var clientes = et.tblCliente.Where(f => f.Carteira.Equals(carteira));

            //Todo..
            //Será necessario fazer um join para trazer o nome em uma única pesquisa (Lambda).
            foreach (var chamado in chamadosAuxiliar)
            {
                //Localiza o nome do cliente
                foreach (var chamadoCliente in clientes)
                {
                    if (chamado.IdCliente == chamadoCliente.Id)
                    {
                        ClienteNR clienteNR = new ClienteNR();

                        clienteNR.IdCliente = chamadoCliente.Id;
                        clienteNR.NomeCliente = chamadoCliente.Nome;
                       
                        
                        chamados.Add(clienteNR);
                    }
                }
            }

            //Verifica se já existe chamado deste cliente e soma a quantidade.
            foreach (var chamado in chamados)
            {
                ClienteNR clienteNR = new ClienteNR();

                

                bool verificaCliente = clienteNRColecao.Any(c => c.IdCliente.Equals(chamado.IdCliente));

                if (verificaCliente == false)
                {
                    clienteNR.Assunto = chamado.Assunto;
                    clienteNR.NomeCliente = chamado.NomeCliente;
                    clienteNR.IdCliente = chamado.IdCliente;
                    clienteNR.Quantidade = 1;
                    clienteNRColecao.Add(clienteNR);
                }
                else if (verificaCliente == true)
                {
                    clienteNRColecao.Where(w => w.IdCliente.Equals(chamado.IdCliente)).ToList().ForEach(f => f.Quantidade += 1);
                }
            }


            return clienteNRColecao;
        }

        public ChamadoDetalhadoColecao ConsultarNrDetalhado(int id, DateTime inicial, DateTime final, bool recorrentes, bool chamadoPerdido)
        {

            ChamadoDetalhadoColecao chamadoDetalhadoColecao = new ChamadoDetalhadoColecao();
            RBNumerosEntities et = new RBNumerosEntities();
          
            try
            {          
                var chamados = et.tblChamado.Where(c => c.IdCliente == id && c.DataAbertura.Year >= inicial.Year && c.DataAbertura.Month >= inicial.Month && c.DataAbertura.Day >= inicial.Day &&
                                                       c.DataAbertura.Year <= final.Year && c.DataAbertura.Month <= final.Month && c.DataAbertura.Day <= final.Day &&
                                                       c.tblTecnico.CarteiraSN == true).ToList();

                if (recorrentes == false)
                    chamados.RemoveAll(a => a.Assunto == "CHAMADO RECORRENTE" || a.TipoChamado == "RECORRENTE");

                if (chamadoPerdido == false)
                    chamados.RemoveAll(a => a.Assunto == "CHAMADO PERDIDO (SEM CONTATO)");

                foreach (var chamado in chamados)
                {
                    ChamadoDetalhado chamadoDetalhado = new ChamadoDetalhado();

                    chamadoDetalhado.Id = chamado.Id;
                    chamadoDetalhado.Nome = chamado.tblTecnico.Nome;
                    chamadoDetalhado.DataAbertura = chamado.DataAbertura;
                    chamadoDetalhado.Assunto = chamado.Assunto;

                    chamadoDetalhadoColecao.Add(chamadoDetalhado);
                }
   
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possivel consultar chamados detalhados: " + ex);
            }

            return chamadoDetalhadoColecao;

        }
    }
}









