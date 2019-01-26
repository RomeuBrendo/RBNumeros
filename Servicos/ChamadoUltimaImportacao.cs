using System;
using System.Linq;

namespace Servicos
{
    public class ChamadoUltimaImportacao
    {
        public DateTime Consultar()
        {
            RBNumerosEntities et = new RBNumerosEntities();

            return et.tblChamado.Max(a => a.DataAbertura);
        }
    }
}
