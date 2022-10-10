namespace TestDedicnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test B, autor Miloš Tesař C3b");
            Auto a1 = new Auto(45, 23);
            NakladniAuto a2 = new NakladniAuto(80, 40, 12);
            a1.NalijPalivo(3);
            Majitel m1 = new Majitel("Jan", "Novak", a1);
            Majitel m2 = new Majitel("Karel", "Sykora", a2);
            Console.WriteLine(m1);
            Console.WriteLine(m2);
        }
    }
}