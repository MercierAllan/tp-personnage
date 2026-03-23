namespace Tp_personnage;

class Program
{
    static void Main(string[] args)
    {
        Personnage p1 = new Personnage("Arthur", 100, 10);
        p1.Afficher();
        Console.WriteLine("Arthur subit 20 points de dégâts : ");
        p1.RecevoirDegats(20);
        p1.Afficher();

        Guerrier g1 = new Guerrier("Lancelot", 120, 15, 30);
        Magicien m1 = new Magicien("Merlin", 80, 20, 50);
        g1.Afficher();
        m1.Afficher();
    }
}
