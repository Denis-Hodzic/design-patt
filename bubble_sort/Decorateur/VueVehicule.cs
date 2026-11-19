using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Decorateur
{
    public class VueVehicule : ComposantGraphiqueVehicule
    {
        public void affiche()
        {
            Console.WriteLine("Affichage du véhicule");
        }
    }
}
