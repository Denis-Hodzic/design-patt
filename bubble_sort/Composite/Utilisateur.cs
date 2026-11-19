using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Composite
{
    public class Utilisateur
    {
        public static void Executer()
        {
            Société société1 = new SociétéSansFiliale();
            société1.ajouteVéhicule();

            Société société2 = new SociétéSansFiliale();
            société2.ajouteVéhicule();
            société2.ajouteVéhicule();

            Société groupe = new SociétéMère();
            groupe.ajouteFiliale(société1);
            groupe.ajouteFiliale(société2);
            groupe.ajouteVéhicule();

            Console.WriteLine("Coût d'entretien total du groupe : " +
                groupe.calculeCoûtEntretien());
        }
    }
}
