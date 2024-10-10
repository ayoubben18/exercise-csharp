using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    internal class Program
    {
        static string[] JoursExistant = { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
        static string[] MoisExistant = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

        static void Main(string[] args)
        {
            bool dateValide = false;

            while (!dateValide)
            {
                Console.WriteLine("Entrer une date: ");
                string date = Console.ReadLine();
                string[] dateParts = date.Split(new char[] { '/', '.', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

                if (dateParts.Length != 3)
                {
                    Console.WriteLine("Format de date invalide. Veuillez entrer la date au format JJ/MM/AAAA.");
                    continue;
                }

                if (!int.TryParse(dateParts[0], out int jour) || !int.TryParse(dateParts[1], out int jourDuMois) || !int.TryParse(dateParts[2], out int mois))
                {
                    Console.WriteLine("Format de date invalide. Assurez-vous que tous les éléments sont des nombres.");
                    continue;
                }

                if (jour < 1 || jour > 7 || jourDuMois < 1 || jourDuMois > 31 || mois < 1 || mois > 12)
                {
                    Console.WriteLine("Le format de date est invalide.\nAssurez-vous que le jour est entre 1 et 31,\nle mois entre 1 et 12\net le jour de la semaine entre 1 et 7.");
                    continue;
                }


                Console.WriteLine("La date est valide.");
                string jourDeLaSemaine = JoursExistant[jour - 1];
                string moisDeLAnnee = MoisExistant[mois - 1];
                Console.WriteLine("{0} {1} {2}", jourDeLaSemaine, jourDuMois, moisDeLAnnee);
                dateValide = true;
            }
        }
    }
}
