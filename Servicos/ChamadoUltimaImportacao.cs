using System;
using System.Linq;

namespace Servicos
{
    public class ChamadoUltimaImportacao
    {
        public DateTime Consultar()
        {
            RBNumerosEntities et = new RBNumerosEntities();
            try
            {
                return et.tblChamado.Max(a => a.DataAbertura);
            }
            catch
            {
                return DateTime.Now;
            }
        }
    }
}
