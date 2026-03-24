class Magicien : Personnage
{
    private int puissanceMagique;

    public Magicien(string nom, int pointsDeVie, int puissanceMagique)
        : base(nom, pointsDeVie)
    {
        this.puissanceMagique = puissanceMagique;
    }

    public override void Afficher()
    {
        Console.WriteLine($"Magicien : {nom}, PV : {pointsDeVie}, Puissance magique : {puissanceMagique}");
    }

    public void LancerSort()
    {
        Console.WriteLine($"{nom} lance un sort");
    }

    public override string ToString()
    {
        return $"Magicien : {nom}, PV : {pointsDeVie}, Puissance magique : {puissanceMagique}";
    }
}