using System.Linq;
using Servicos.Entidades;

namespace Servicos
{
    public class TecnicoNegocios
    {
        
        tblTecnico tecnico = new tblTecnico();
        TecnicoColecao tecnicoColecao = new TecnicoColecao();
        RBNumerosEntities et = new RBNumerosEntities();

        public TecnicoColecao Consultar(string carteira)
        {
            
            var tecnicos = et.tblTecnico.Where(a => a.Carteira.Equals(carteira)).AsParallel().ToList();

          //  var plantao = et.tblTecnico.Where(a => a.Nome.Equals("PLANTAO")||a.Nome.Equals("PLANTAO2")).ToList();

            tecnicos.ForEach(a => { tecnicoColecao.Add(a); });
          //  plantao.ForEach(a => { tecnicoColecao.Add(a); });
            
            return tecnicoColecao;
        }

        public void SalvarGrid()
        {
         
            et.SaveChanges();
        }



    }
}
