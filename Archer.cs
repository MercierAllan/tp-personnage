class Archer : Personnage
{
    private int precision;

    public Archer(string nom, int pointsDeVie, int precision)
        : base(nom, pointsDeVie)
    {
        this.precision = precision;
    }

    public void Tirer()
    {
        Console.WriteLine($"{nom} tire une flèche avec une précision de {precision}");
    }

    public override string ToString()
    {
        return $"Archer : {nom}, PV : {pointsDeVie}, Précision : {precision}";
    }

    public override void Afficher()
    {
        Console.WriteLine(this.ToString());
    }
}