using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Singleton
{
    public class ScooterEssence : Scooter
    {
        public override void Demarrer()
        {
            Console.WriteLine("Le scooter à essence démarre.");
        }
        public override void Arreter()
        {
            Console.WriteLine("Le scooter à essence s'arrête.");
        }
    }
}
