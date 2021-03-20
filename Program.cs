using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Converta temperaturas de °F para °C ");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();


            Console.Write("Insira a temperatura em °F: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double f = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.ResetColor();

            double resultado = (f-32)/1.8;
            Console.Write($"Temperatura convertida em °C: {resultado:N2} ");
            Console.Write("\n");
            Console.WriteLine();


        }
    }
}
