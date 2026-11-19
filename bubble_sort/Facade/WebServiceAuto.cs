using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Facade
{
    // Interface de la façade
    public interface WebServiceAuto
    {
        string document(int index);
        IList<string> chercheVehicules(int prixMoyen, int ecartMax);
    }
}
