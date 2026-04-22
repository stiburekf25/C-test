using System.Security.Authentication.ExtendedProtection;

namespace Piskvorky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte ve hře Piškvorky!");
            Console.WriteLine("Vyberte si X nebo O:");
            string? vyber;

            vyber = Console.ReadLine();

            while (vyber != "X" && vyber != "O")
            { 
            Console.WriteLine("Neplatný výběr.");
            Console.WriteLine("Vyberte si X nebo O:");
                vyber = Console.ReadLine();
            }

            string? pocitac;

            pocitac = "";

            if (vyber == "X")
            {
                pocitac = "O";
            }
            else
            {
                pocitac = "X";
            }

            Console.WriteLine("Počitač bere: " + pocitac);

            Console.WriteLine("Hra začíná!");

            string[,] pole = new string[3, 3];

            Console.WriteLine(pole);

            for (int i = 0; i < 3; i++)
            { 
            
            }



        }
    }
}
