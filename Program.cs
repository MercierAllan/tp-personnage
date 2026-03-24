namespace Tp_personnage;

class Program
{
    static void Main(string[] args)
    {
        Personnage p1 = new Personnage("Arthur", 100);
        p1.Afficher();

        Console.WriteLine("Sans réduction : ");
        Console.WriteLine("Arthur subit 30 dégâts");
        p1.RecevoirDegats(30);
        p1.Afficher();

        Console.WriteLine("Avec réduction : ");
        Console.WriteLine("Arthur subit 30 dégâts avec une réduction de 10");
        p1.RecevoirDegats(30, 10);
        p1.Afficher();

        Guerrier g1 = new Guerrier("Lancelot", 120, 30);
        Magicien m1 = new Magicien("Merlin", 80, 50);
        Console.WriteLine(g1);
        Console.WriteLine(m1);
        
        Archer a1 = new Archer("Robin", 90, 75);
        List<Personnage> personnages = new List<Personnage>();
        personnages.Add(g1);
        personnages.Add(m1);
        personnages.Add(a1);

        foreach (Personnage p in personnages)
        {
            p.Afficher();

            if (p is Guerrier guerrier)
            {
                ((Guerrier)p).Attaquer();
            }
            else if (p is Magicien magicien)
            {
                magicien.LancerSort();
            }
            else if (p is Archer archer)
            {
                archer.Tirer();
            }

        }
    }
}
