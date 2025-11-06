namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int i = 123;
            string s = "kip";

            int aantalversnellingen_auto1 = 5;
            string merk_auto1 = "BMW";

            // Maak een nieuw object van de klasse Auto
            Auto auto1 = new Auto();
            auto1.Merk = "BMW";
            auto1.MaxSnelheid = 250;
            auto1.MotorStatus = true ;

            Console.WriteLine(auto1.Snelheid);
            auto1.GeefGas();
            Console.WriteLine(auto1.Snelheid);


        }
    }
}
