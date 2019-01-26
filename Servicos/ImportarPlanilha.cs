using System;
using System.Linq;
using ClosedXML.Excel;

namespace Servicos
{
    public class ImportarPlanilha
    {
        //Inseri um novo chamado
        public void InserirChamado()
        {
     
            tblCliente cliente = new tblCliente();
            tblTecnico tecnico = new tblTecnico();

            var wb = new XLWorkbook(@"C:\RBNumeros\chamados.xlsx");
            var planilha = wb.Worksheet(1);
            var linha = 2;

            while (true)
            {
                RBNumerosEntities rBNumerosEntities = new RBNumerosEntities();

                tblChamado chamado = new tblChamado();

                //Verifica ate onde vai a planilha.
                var numeroChamado = planilha.Cell("A" + linha.ToString()).Value.ToString();
                if (string.IsNullOrEmpty(numeroChamado)) break;

                int idChamado =Convert.ToInt32(numeroChamado);

                     //verificaChamado = rBNumerosEntities.tblChamado.Max(c => c.Id);

                 var  verificaChamado = rBNumerosEntities.tblChamado.Where(c => c.Id == idChamado).Select(a => a.Id).ToList();
                
               

                if (verificaChamado.Count == 0)
                {

                    var dataAbertura = (planilha.Cell("D" + linha.ToString()).Value.ToString());
                    var dataFecha = (planilha.Cell("E" + linha.ToString()).Value.ToString());
                    var carteira = (planilha.Cell("H" + linha.ToString()).Value.ToString());
                    var abertoPor = (planilha.Cell("L" + linha.ToString()).Value.ToString());
                    var assunto = (planilha.Cell("P" + linha.ToString()).Value.ToString());
                    var tipo = (planilha.Cell("N" + linha.ToString()).Value.ToString());
                    var titulo = (planilha.Cell("Q" + linha.ToString()).Value.ToString());
                    var clienteP = (planilha.Cell("F" + linha.ToString()).Value.ToString());
                    var redeCliente = (planilha.Cell("G" + linha.ToString()).Value.ToString());
                
                    chamado.Id = Convert.ToInt32(numeroChamado);

                    //Verifica se o cliente ja esta cadastrado
                    int clienteCadastrado = ConsultarCliente(clienteP, carteira);

                        //Caso nao tenha cliente cadastro
                        if (clienteCadastrado == 0)
                        {
                            chamado.IdCliente = InserirCliente(clienteP, carteira,redeCliente);
                            

                        }
                        else
                        {
                            chamado.IdCliente = clienteCadastrado;
                        }

                     
                    
                    //Verifica se tem tcnico cadastrado
                    var tecnicoCadastro = rBNumerosEntities.tblTecnico.Where(c => c.Nome.Equals(abertoPor)).Select(c => c.Id).ToList();


                    if (tecnicoCadastro.Count == 0)

                    {
                        chamado.IdAbertoPor = InserirTecnico(abertoPor, carteira);
                    }
                    else
                    {
                        tecnicoCadastro.ForEach(x => { chamado.IdAbertoPor = Convert.ToInt32(x); });
                    }

                    chamado.DataAbertura = Convert.ToDateTime(dataAbertura);

                    if (dataFecha != "")
                        chamado.DataFechamento = Convert.ToDateTime(dataFecha);

                    chamado.Carteira = (carteira);
                    chamado.Assunto = assunto;
                    chamado.TipoChamado = tipo;
                    chamado.Titulo = titulo;

                    rBNumerosEntities.tblChamado.Add(chamado);

                    rBNumerosEntities.SaveChanges();   
                }
                linha++;
            }
        
        }

        //Verifica se o cliente já esta cadastrado
        public int ConsultarCliente(string nome, string carteira)
        {
            RBNumerosEntities et = new RBNumerosEntities();

            int idSelecionado =0;
            string _carteira = null;
            string carteiraNova; //= carteira.Trim();

            
            
            var id = et.tblCliente.Where(c => c.Nome.Equals(nome)).ToList();

            try
            {
                
                id.ForEach(x => { idSelecionado = x.Id; _carteira = x.Carteira; });

                //Retira o espaço vazio
                carteiraNova = _carteira.Replace(" ", "");

                if (carteiraNova != carteira)
                    return 0;
            }
            catch
            {
                idSelecionado = 0;
            }

        

            return idSelecionado;
        }

        //Inseri um novo cliente
        public int InserirCliente(string nome, string carteira, string rede)
        {
           // string _rede = rede;

            tblCliente cliente = new tblCliente();

            RBNumerosEntities et = new RBNumerosEntities();

            var red = et.tblRedeCliente.Where(c => c.Nome == rede).ToList();

            if(red.Count==0)
            {
                cliente.IdRede = InserirRede(rede);
            }
            else
            {
                red.ForEach(a => { cliente.IdRede = a.Id; });
            }

            cliente.Nome = nome;
            cliente.Carteira = carteira;

            et.tblCliente.Add(cliente);
            
            et.SaveChanges();

            return et.tblCliente.Max(c => c.Id);
           
        }

        //Inserir uma nova rede
        public int InserirRede(string nome)
        {
            tblRedeCliente redeCliente = new tblRedeCliente();

            RBNumerosEntities et = new RBNumerosEntities();

            redeCliente.Nome = nome;

            et.tblRedeCliente.Add(redeCliente);

            et.SaveChanges();

            return et.tblRedeCliente.Max(c => c.Id);
        }

        //Inseri um novo tecnico
        public int InserirTecnico(string nome,string carteira)
        {
            tblTecnico tecnico = new tblTecnico();
            RBNumerosEntities et = new RBNumerosEntities();

            tecnico.Nome = nome;
            tecnico.Carteira = carteira;

            et.tblTecnico.Add(tecnico);

            et.SaveChanges();

            return et.tblTecnico.Max(c => c.Id);
        }
    }
}
