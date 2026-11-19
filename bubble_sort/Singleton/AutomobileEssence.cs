using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Singleton
{
    public class AutomobileEssence : Automobile
    {
        public override void Demarrer()
        {
            Console.WriteLine("L'automobile à essence démarre.");
        }
        public override void Arreter()
        {
            Console.WriteLine("L'automobile à essence s'arrête.");
        }
    }
}
