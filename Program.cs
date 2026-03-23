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
    }
}
