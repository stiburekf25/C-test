namespace test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? ano_ne;
            do
            {
                Console.WriteLine("Zadej kámen, nůžky nebo papír:");
                string? vyber;

                vyber = Console.ReadLine();

                while (vyber != "kámen" && vyber != "nůžky" && vyber != "papír")
                {
                    Console.WriteLine("Neplatný výběr.");
                    vyber = Console.ReadLine();
                }

                Console.WriteLine("Počítač vybírá...");

                Random vyber_predmetu = new Random();

                int volba_pocitace = vyber_predmetu.Next(1, 4);
                string pocitac = "";

                if (volba_pocitace == 1)
                {
                    pocitac = "kámen";
                }
                else if (volba_pocitace == 2)
                {
                    pocitac = "nůžky";
                }
                else
                {
                    pocitac = "papír";
                }

                Console.WriteLine(pocitac);

                if (pocitac == vyber)
                {
                    Console.WriteLine("Remíza!");
                }
                else if (vyber == "kámen" && pocitac == "nůžky" || vyber == "nůžky" && pocitac == "papír" || vyber == "papír" && pocitac == "kámen")
                {
                    Console.WriteLine("Vyhrál jsi!");
                }
                else if (vyber == "kámen" && pocitac == "papír" || vyber == "nůžky" && pocitac == "kámen" || vyber == "papír" && pocitac == "nůžky")
                {
                    Console.WriteLine("Prohrál jsi!");
                }

                Console.WriteLine("pokračování hry?");
                Console.WriteLine("napiš ano nebo ne");

                ano_ne = Console.ReadLine();

                while (ano_ne != "ano" && ano_ne != "ne")
                {
                    Console.WriteLine("Neplatný výběr.");
                    ano_ne = Console.ReadLine();
                }

            } while (ano_ne == "ano");









        }
    }
}
