using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Singleton
{
    public class FabriqueVehiculeEssence : Fabriquevehicule
    {

        private static FabriqueVehiculeEssence? _instance;
        private static readonly object _lock = new object();

        public FabriqueVehiculeEssence() { }

        public static FabriqueVehiculeEssence Instance
        {
            get
            {
                lock (_lock)
                {
                    _instance ??= new FabriqueVehiculeEssence();
                    return _instance;
                }
            }
        }

        public void CreerAutomobile()
        {
            Console.WriteLine("Création d'une automobile à essence.");
        }

        public void CreerScooter()
        {
            Console.WriteLine("Création d'un scooter à essence.");
        }
    }
}
