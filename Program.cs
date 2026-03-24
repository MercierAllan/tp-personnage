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

        
        List<Personnage> personnages = new List<Personnage>();
        personnages.Add(g1);
        personnages.Add(m1);

        for (int i = 0; i < personnages.Count; i++)
        {
            personnages[i].Afficher();
            
            if (personnages[i] is Guerrier)
            {
                ((Guerrier)personnages[i]).Attaquer();
            }
            else if (personnages[i] is Magicien)
            {
                ((Magicien)personnages[i]).LancerSort();
            }
        }
    }
}
