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
        base.Afficher();
        Console.WriteLine($"Armure: {armure}");
    }
}