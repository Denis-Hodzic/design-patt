using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Facade
{
    public interface Catalogue
    {
        IList<string> retrouveVehicules(int prixMin, int prixMax);
    }
}
