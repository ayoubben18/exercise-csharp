using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    internal class Program
    {
        public string nom;
        public double prix_HT;
        public double prix_TTC;
        public Program(string nom, double prix_HT)
        {
            this.nom = nom;
            this.prix_HT = prix_HT;
            this.prix_TTC = prix_HT * 1.2;
        }
        static void Main(string[] args)
        {
            string nom;
            double prix_HT;
            Console.WriteLine("Entrer le nom du produit: ");
            nom = Console.ReadLine();
            Console.WriteLine("Entrer le prix HT: ");
            while (!double.TryParse(Console.ReadLine(), out prix_HT))
            {
                Console.WriteLine("Entrer un prix valide: ");
            }

            Program produit = new Program(nom, prix_HT);

            Console.WriteLine("Le prix de {0} TTC est {1:F2}Dhs", produit.nom, produit.prix_TTC);

        }
    }
}