class Guerrier : Personnage
{
    private int force;

    public Guerrier(string nom, int pointsDeVie, int Attributs, int force) : base(nom, pointsDeVie, Attributs)
    {
        this.force = force;
    }

    public new void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Force: {force}");
    }   
}