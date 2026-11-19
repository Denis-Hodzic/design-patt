namespace bubble_sort.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue.Instance.Initialiser();
            bubble_sort.Composite.Utilisateur.Executer();
            bubble_sort.Decorateur.VueCatalogue.Executer();
            bubble_sort.Facade.UtilisateurWebService.Executer();
        }
    }

    public sealed class Catalogue
    {
        private static Catalogue? _instance;
        private static readonly object _lock = new object();

        private Catalogue() { }

        public static Catalogue Instance
        {
            get
            {
                lock (_lock)
                {
                    _instance ??= new Catalogue();
                    return _instance;
                }
            }
        }

        public void Initialiser()
        {
            Fabriquevehicule fabriqueEssence = new FabriqueVehiculeEssence();
            fabriqueEssence.CreerAutomobile();
            fabriqueEssence.CreerScooter();

            Fabriquevehicule fabriqueElectrique = new FabriqueVehiculeÉlectricité();
            fabriqueElectrique.CreerAutomobile();
            fabriqueElectrique.CreerScooter();

            Scooter scooterEssence = new ScooterEssence();
            scooterEssence.Demarrer();

            Scooter scooterElectrique = new ScooterÉlectrique();
            scooterElectrique.Demarrer();
        }
    }
}
