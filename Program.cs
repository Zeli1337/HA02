namespace HausaufgabenV02;

class Program
{
    static void Main(string[] args)
    {
        Punkt a = new Punkt(0,0);
        Punkt b = new Punkt(0,5);
        Punkt c = new Punkt(5,0);
        Punkt d = new Punkt(5,5);

        List<Punkt> auflistung = new List<Punkt>();
        auflistung.Add(a);
        auflistung.Add(b);
        auflistung.Add(c);  
        auflistung.Add(d);

        Kantenzug kantenzug = new Kantenzug(auflistung, auflistung.Count);
        System.Console.WriteLine(kantenzug.ToString());
        Kantenzug k =  kantenzug.copy();
        k.verschieben(5,5);
        kantenzug.verschieben(4,3);
        System.Console.WriteLine(k.ToString());
        System.Console.WriteLine(kantenzug.ToString());
        System.Console.WriteLine(k.ToString());
    }
}
