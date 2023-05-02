namespace Ejercicio10.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fah, reaumur;
            Console.Write("Ingrese el valor de la temperatura en grados Celsius:");
            celsius=double.Parse(Console.ReadLine());
            fah = ConvertirDeCelsiusAFah(celsius);
            reaumur = ConvertirDeCelsiusAReaumur(celsius);
            Console.WriteLine($"{celsius} grados C equivalen a {fah} grados F");
            Console.WriteLine($"{celsius} grados C equivalen a {reaumur} grados R");
        }

        private static double ConvertirDeCelsiusAReaumur(double temperatura)
        {
            return 0.8 * temperatura;
        }

        private static double ConvertirDeCelsiusAFah(double celsius)
        {
            return 1.8 * celsius + 32;
        }
    }
}