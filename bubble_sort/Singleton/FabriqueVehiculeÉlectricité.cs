using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Singleton
{
    public class FabriqueVehiculeÉlectricité : Fabriquevehicule
    {
        public void CreerAutomobile()
        {
            Console.WriteLine("Création d'une automobile électrique.");
        }

        public void CreerScooter()
        {
            Console.WriteLine("Création d'un scooter électrique.");
        }
    }
}
