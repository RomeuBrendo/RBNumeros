using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Entidades
{
    public class ClientePrioridade
    {
        public string Nome { get; set; }
        public List<tblChamado> Chamados { get; set; }
    }
}
