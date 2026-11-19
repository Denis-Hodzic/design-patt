using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Facade
{
    // Façade : point d'entrée unique vers les composants
    public class WebServiceAutoImpl : WebServiceAuto
    {
        protected Catalogue catalogue;
        protected GestionDocument gestionDocument;
        protected RepriseVehicule repriseVehicule;

        public WebServiceAutoImpl()
        {
            catalogue = new ComposantCatalogue();
            gestionDocument = new ComposantGestionDocument();
            repriseVehicule = new ComposantRepriseVehicule();
        }

        public string document(int index)
        {
            return gestionDocument.document(index);
        }

        public IList<string> chercheVehicules(int prixMoyen, int ecartMax)
        {
            return catalogue.retrouveVehicules(prixMoyen - ecartMax, prixMoyen + ecartMax);
        }
    }
}
