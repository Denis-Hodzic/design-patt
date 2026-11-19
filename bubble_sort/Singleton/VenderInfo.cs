using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort.Singleton
{
    public class VenderInfo
    {
        private static VenderInfo? _instance;
        private static readonly object _lock = new object();

        public string Nom { get; private set; } = string.Empty;
        public string Adresse { get; private set; } = string.Empty;

        private VenderInfo() { }

        public static VenderInfo Instance
        {
            get
            {
                lock (_lock)
                {
                    _instance ??= new VenderInfo();
                    return _instance;
                }
            }
        }

        public void Affiche(string nom, string adresse)
        {
            Nom = nom;
            Adresse = adresse;
        }
    }
}
