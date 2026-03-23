class Personnage
{
    private string nom;
    private int pointsDeVie;
    protected int Attributs;

    public Personnage(string nom, int pointsDeVie, int Attributs)
    {
        this.nom = nom;
        this.pointsDeVie = pointsDeVie;
        this.Attributs = Attributs;
    }

    public void RecevoirDegats(int degats)
    {
        pointsDeVie -= degats;
        if (pointsDeVie < 0)
        {
            pointsDeVie = 0;
        }
    }

    public void Afficher()
    {
        Console.WriteLine($"Nom: {nom}, Points de Vie: {pointsDeVie}, Attributs: {Attributs}");
    }
}