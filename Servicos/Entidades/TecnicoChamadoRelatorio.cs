using System.Collections.Generic;
namespace Servicos.Entidades
{
    public class TecnicoChamadoRelatorio 
    {
        
        public string NomeTecnico { get; set; }
        public List<tblChamado> Chamados { get; set; }
  
    }
}
