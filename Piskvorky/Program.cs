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

            string[] herniPole = new string[9];

            for (int i = 0; i < 9; i++)
            {
                herniPole[i] = (i + 1).ToString();
            }

            bool hra_probiha = true;

            string prave_hraje = "";

            while (!NastalaRemiza(herniPole, vyber, pocitac) && !NastalaVyhra(herniPole))
            {
                prave_hraje = "Člověk";
                VypisPole(herniPole);

                Console.WriteLine("Zadejte číslo pole, kam chcete umístit svůj symbol:");
                string? vyber_pole_hrac = Console.ReadLine();
                int vyber_pole_hrac_cislo = Convert.ToInt32(vyber_pole_hrac) - 1;

                herniPole[vyber_pole_hrac_cislo] = vyber;

                VypisPole(herniPole);

                if (NastalaRemiza(herniPole, vyber, pocitac) || NastalaVyhra(herniPole))
                    break;

                prave_hraje = "Počítač";
                Console.WriteLine("Počítač vybírá pole...");

                Random vyber_pocitace = new Random();

                int vyber_pole_pocitace = vyber_pocitace.Next(0, 9);

                while (herniPole[vyber_pole_pocitace] == vyber || herniPole[vyber_pole_pocitace] == pocitac)
                {
                    vyber_pole_pocitace = vyber_pocitace.Next(0, 9);
                }

                herniPole[vyber_pole_pocitace] = pocitac;
            }

            if (NastalaRemiza(herniPole, vyber, pocitac))
            {
                Console.WriteLine("Remíza!");
            }
            else
            {
                Console.WriteLine("Vyhrál " + prave_hraje + "!");
            }

        }
        static void VypisPole(string[] poleKtereSeMaVypsat)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.Write(poleKtereSeMaVypsat[i] + " ");
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        static bool NastalaVyhra(string[] pole)
        {
            return (
                    (pole[0] == pole[1] && pole[1] == pole[2]) ||
                    (pole[3] == pole[4] && pole[4] == pole[5]) ||
                    (pole[6] == pole[7] && pole[7] == pole[8]) ||

                    (pole[0] == pole[3] && pole[3] == pole[6]) ||
                    (pole[1] == pole[4] && pole[4] == pole[7]) ||
                    (pole[2] == pole[5] && pole[5] == pole[8]) ||
                    (pole[0] == pole[4] && pole[4] == pole[8]) ||
                    (pole[2] == pole[4] && pole[4] == pole[6])
               );
        }

        static bool NastalaRemiza(string[] pole, string znak_cloveka, string znak_pocitace)
        {
            int volna_policka = pole.Length;

            foreach (string znak in pole)
            {
                if (znak == znak_cloveka || znak == znak_pocitace)
                    volna_policka--;

            }

            return volna_policka == 0;
        }
    }

}
