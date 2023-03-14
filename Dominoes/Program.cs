class Dominoes
{
    public int Domino1;
    public int Domino2;

    public Dominoes(int Domino1, int Domino2)
    
        {this.Domino1=Domino1; this.Domino2=Domino2;}
    
    public static int operator +(Dominoes a, Dominoes b)
    {
     int suma = a.Domino1 + a.Domino2 + b.Domino1 + b.Domino2;
     return suma;   
    }
internal class Program
{
    private static void Main(string[] args)
    {
        Dominoes domino = new Dominoes (1,1);
        Dominoes domino2 = new Dominoes (1,2);
        int total = domino + domino2;
        Console.WriteLine(total);
    }
}
}