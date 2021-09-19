using System;

namespace exercicios_etec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" Digite o valor em graus Farenheint:");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("F = ");
            string Farenheint = Console.ReadLine();

            double Celcius = ( Convert.ToDouble( Farenheint) - 32) / 1.8;

            Console.Write($"\n{Farenheint}F equivalente a ");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{Celcius}C");

            Console.ReadKey();
            Console.ResetColor();




        }
    }
}
