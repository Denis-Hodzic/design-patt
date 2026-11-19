using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Facade
{
    public class ComposantRepriseVehicule : RepriseVehicule
    {
        public double estimeReprise(string description)
        {
            Console.WriteLine("Estimation de la reprise du véhicule : " + description);
            return 0.0;
        }
    }
}
