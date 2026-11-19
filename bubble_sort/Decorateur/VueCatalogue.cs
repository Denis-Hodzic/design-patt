using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Decorateur
{
    public class VueCatalogue
    {
        public static void Executer()
        {
            VueVehicule vueVehicule = new VueVehicule();
            ModeleDecorateur modeleDecorateur = new ModeleDecorateur(vueVehicule);
            MarqueDecorateur marqueDecorateur = new MarqueDecorateur(modeleDecorateur);
            marqueDecorateur.affiche();
        }
    }
}
