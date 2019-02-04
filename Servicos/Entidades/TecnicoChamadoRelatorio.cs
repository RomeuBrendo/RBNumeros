using System.Collections.Generic;
namespace Servicos.Entidades
{
    public class TecnicoChamadoRelatorio 
    {
        
        public string NomeTecnico { get; set; }
        public List<tblChamado> Chamados { get; set; }

        public int PrioridadeBaixa { get; set; }
        public int PrioridadeMedia { get; set; }
        public int PrioridadeAlta { get; set; }
        public int PrioridadeNaoDefinida { get; set; }
    }
}
