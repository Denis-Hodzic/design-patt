using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Singleton
{
    public class ScooterÉlectrique : Scooter
    {
        public override void Demarrer()
        {
            Console.WriteLine("Le scooter électrique démarre.");
        }
        public override void Arreter()
        {
            Console.WriteLine("Le scooter électrique s'arrête.");
        }
    }
}
