using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Entidades
{
    public class ClienteNR : tblChamado
    {
        public int Quantidade { get; set; }
        public string NomeCliente { get; set; }
       
    }
}
