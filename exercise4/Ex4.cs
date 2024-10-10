using System;
using System.Linq;

namespace exercise4
{
    internal class Program
    {
        private int nbRAppr;
        private int[] apprNotes;
        private double moyenne;
        private int somme;
        private int max;
        private int min;

        public Program(int nbRAppr)
        {
            if (nbRAppr <= 0)
            {
                throw new ArgumentException("Le nombre d'apprenants doit être positif.");
            }
            this.nbRAppr = nbRAppr;
            this.apprNotes = new int[nbRAppr];
        }

        private void InputNotes()
        {
            int n = 0;
            for (int i = 0; i < nbRAppr; i++)
            {
                Console.WriteLine("Entrer la note de l'apprenant {0}: ", i + 1);
                while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 20 )
                {
                    Console.WriteLine("Entrer une note valide: ");
                }
                apprNotes[i] = n;
            }
        }

        private void CalculateStatistics()
        {
            max = apprNotes.Max();
            min = apprNotes.Min();
            somme = apprNotes.Sum();
            moyenne = nbRAppr > 0 ? (double)somme / nbRAppr : 0;
        }

        private void DisplayResults()
        {
            Console.WriteLine("La moyenne des notes est: {0:F2}", moyenne);
            Console.WriteLine("La somme des notes est: {0}", somme);
            Console.WriteLine("La note maximale est: {0}", max);
            Console.WriteLine("La note minimale est: {0}", min);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entrer le nombre d'apprenants: ");
            int nbRAppr;
            while (!int.TryParse(Console.ReadLine(), out nbRAppr) || nbRAppr <= 0)
            {
                Console.WriteLine("Veuillez entrer un nombre valide et positif d'apprenants: ");
            }

            try
            {
                Program program = new Program(nbRAppr);
                program.InputNotes();
                program.CalculateStatistics();
                program.DisplayResults();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite: {0}", ex.Message);
            }
        }
    }
}
