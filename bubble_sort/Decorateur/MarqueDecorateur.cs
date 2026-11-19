using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Decorateur
{
    public class MarqueDecorateur : Decorateur
    {
        public MarqueDecorateur(ComposantGraphiqueVehicule composant) : base(composant) { }

        protected void afficheLogo()
        {
            Console.WriteLine("Logo de la marque");
        }

        public override void affiche()
        {
            base.affiche();
            afficheLogo();
        }
    }
}
