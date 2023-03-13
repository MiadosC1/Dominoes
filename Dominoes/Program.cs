class Dominoes
{
    public int Domino1;
    public int Domino2;

    public Dominoes(int domino, int domino2)
    {
        this.Domino1 = domino;
        this.Domino2 = domino2;
    }

    public static Dominoes operator +(Dominoes a, Dominoes b)
    {
     int Superior = a.Domino1 + b.Domino1;
     int Inferior = a.Domino2 + b.Domino2;
     return new Dominoes(Superior, Inferior);   
    }
internal class Program
{
    private static void Main(string[] args)
    {
        Dominoes d1 = new Dominoes (0,1);
        Dominoes d2 = new Dominoes (0,2);
        int total = d1 + d2;
        Console.WriteLine(total);
    }
}
}