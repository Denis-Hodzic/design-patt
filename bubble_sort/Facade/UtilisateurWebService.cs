using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Facade
{
    public class UtilisateurWebService
    {
        public static void Executer()
        {
            WebServiceAuto webServiceAuto = new WebServiceAutoImpl();
            Console.WriteLine(webServiceAuto.document(0));
            Console.WriteLine(webServiceAuto.document(1));
            IList<string> resultats = webServiceAuto.chercheVehicules(6000, 1000);
            if (resultats.Count > 0)
            {
                Console.WriteLine("Véhicule(s) dont le prix est compris " +
                    "entre 5000 et 7000");
                foreach (string resultat in resultats)
                    Console.WriteLine("   " + resultat);
            }
        }
    }
}
