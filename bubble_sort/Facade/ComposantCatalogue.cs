using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Facade
{
    public class ComposantCatalogue : Catalogue
    {
        protected string[] descriptions = { "Berline 5 portes", "Compact 3 portes", "Espace 5 portes",
                                            "Break 5 portes", "Coupé 2 portes", "Utilitaire 3 portes" };
        protected int[] prix = { 6000, 4000, 8000, 7000, 9000, 5000 };

        public IList<string> retrouveVehicules(int prixMin, int prixMax)
        {
            IList<string> resultat = new List<string>();
            for (int i = 0; i < descriptions.Length; i++)
            {
                if (prix[i] >= prixMin && prix[i] <= prixMax)
                    resultat.Add(descriptions[i]);
            }
            return resultat;
        }
    }
}
