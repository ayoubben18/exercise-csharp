using System;

namespace exercise3
{

    internal class Program

    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Entrer un nombre entier contenant 3 chiffres: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 100 || n > 999)
            {
                Console.WriteLine("Entrer un nombre entier contenant 3 chiffres: ");
            }


            int chiffre1 = n / 100;
            int chiffre2 = (n / 10) % 10;
            int chiffre3 = n % 10;

            if (((Math.Pow(chiffre1, 3) + Math.Pow(chiffre2, 3) + Math.Pow(chiffre3, 3)) == n))
            {
                Console.WriteLine("{0} est un nombre de Armstrong", n);
            }
            else
            {
                Console.WriteLine("{0} n'est pas un nombre de Armstrong", n);
            }



        }

    }
}