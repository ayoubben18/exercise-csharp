using System.Linq;
using System;
namespace exercise5
{
    internal class Program
    {
        int[] tab = new int[20];


        public void RemplireTab()
        {
            Random rand = new Random();
            tab = Enumerable.Range(0, tab.Length).Select(i => rand.Next(1, 101)).ToArray();

        }

        public void AfficherTab()
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }

        public void RechercherTab()
        {
            Console.WriteLine("Entrer un nombre : ");
            int n = 0;

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Entrer un nombre valide: ");
            }

            var matches = tab.Select((value, index) => new { value, index })
                             .Where(x => x.value == n)
                             .ToList();

            int found = matches.Count;
            int lastIndex = found > 0 ? matches.Last().index : -1;

            if (found == 0)
            {
                Console.WriteLine("Le nombre n'existe pas dans le tableau");
            }
            else if (found == 1)
            {
                Console.WriteLine("Le nombre existe une seule fois dans le tableau au rang : {0}", lastIndex);
            }
            else
            {
                Console.WriteLine("Le nombre existe plusieurs fois dans le tableau, dernier rang: {0}", lastIndex);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.RemplireTab();
            program.AfficherTab();
            program.RechercherTab();
        }

    }
}
