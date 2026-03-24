class Personnage
{
    protected string nom;
    protected int pointsDeVie;

    public Personnage(string nom, int pointsDeVie)
    {
        this.nom = nom;
        this.pointsDeVie = pointsDeVie;
    }

    public void RecevoirDegats(int degats)
    {
        pointsDeVie -= degats;
        if (pointsDeVie < 0)
            pointsDeVie = 0;
    }

    public void RecevoirDegats(int degats, int reduction)
    {
        int degatsEffectifs = degats - reduction;
        if (degatsEffectifs < 0)
            degatsEffectifs = 0;

        pointsDeVie -= degatsEffectifs;
        if (pointsDeVie < 0)
            pointsDeVie = 0;
    }

    public virtual void Afficher()
    {
        Console.WriteLine($"{nom}, Points de Vie: {pointsDeVie}");
    }
}