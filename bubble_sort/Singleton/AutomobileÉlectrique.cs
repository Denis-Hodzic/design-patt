using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Singleton
{
    public class AutomobileÉlectrique : Automobile
    {
        public override void Demarrer()
        {
            Console.WriteLine("L'automobile électrique démarre.");
        }
        public override void Arreter()
        {
            Console.WriteLine("L'automobile électrique s'arrête.");
        }
    }
}
