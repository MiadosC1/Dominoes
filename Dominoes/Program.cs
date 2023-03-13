class Dominoes
{
    public int Domino1;
    public int Domino2;

    public Dominoes(int domino, int domino2)
    {
        Domino1 = domino;
        Domino2 = domino2;
    }

    public static Dominoes operator +(Dominoes a, Dominoes b)
    {
     int Superior = a.Domino1 + b.Domino1;
     int Inferior = a.Domino2 + b.Domino2;
     int sumatotal = Superior + Inferior;
     return new Dominoes(Superior, Inferior);   
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}