using System.Collections.Generic;
namespace Servicos.Entidades
{
    public class TecnicoChamadoRelatorio 
    {
        public int IdTecnico { get; set; }
        public string NomeTecnico { get; set; }
        public List<tblChamado> Chamado { get; set; }
    }
}
