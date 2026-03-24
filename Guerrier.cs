class Guerrier : Personnage
{
    private int armure;

    public Guerrier(string nom, int pointsDeVie, int armure)
        : base(nom, pointsDeVie)
    {
        this.armure = armure;
    }

    public override void Afficher()
    {
         Console.WriteLine($"Guerrier : {nom}, PV : {pointsDeVie}, Armure : {armure}");
    }

    public void Attaquer()
    {
        Console.WriteLine($"{nom} attaque");
    }
}