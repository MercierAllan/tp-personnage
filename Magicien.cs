class Magicien : Personnage
{
    private int puissanceMagique;

    public Magicien(string nom, int pointsDeVie, int Attributs, int puissanceMagique) : base(nom, pointsDeVie, Attributs)
    {
        this.puissanceMagique = puissanceMagique;
    }

    public new void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Puissance Magique: {puissanceMagique}");
    }

    //Ajout d'un constructeur de la classe mere avec base
    public Magicien(string nom, int pointsDeVie, int Attributs) : base(nom, pointsDeVie, Attributs)
    {
        this.puissanceMagique = 0;
    }
}