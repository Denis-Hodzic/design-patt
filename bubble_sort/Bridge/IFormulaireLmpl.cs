using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Bridge
{
    public interface IFormulaireLmpl
    {
        void dessineTexte()
        {
            Console.WriteLine("Affichage du formulaire d'immatriculation...");
        }

        void gereZoneSaisie()
        {
            Console.WriteLine("gestion saisie");
        }
    }
}
