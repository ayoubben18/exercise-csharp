using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    internal class Program
    {
        static void InctTab(ref int[] tab)
        {
            if (tab == null || tab.Length == 0)
                throw new ArgumentException("Le tableau ne doit pas être vide ou null.");


            for (int i = 0; i < tab.Length; i++)
            {
                tab[i]++;
            }
        }

        static int[] IncNewTab(int[] tab)
        {
            if (tab == null || tab.Length == 0)
                throw new ArgumentException("Le tableau ne doit pas être vide ou null.");

            int[] newTab = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                newTab[i] = tab[i] + 1;
            }

            return newTab;

        }

        static void IncNewTabOut(int[] tab, out int[] incrementedArray)
        {
            if (tab == null || tab.Length == 0)
                throw new ArgumentException("Le tableau ne doit pas être vide ou null.");

            incrementedArray = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                incrementedArray[i] = tab[i] + 1;
            }
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ", tab));

            InctTab(ref tab);
            Console.WriteLine(string.Join(", ", tab));

            tab = new int[] { 1, 2, 3, 4, 5 };
            int[] newTab = IncNewTab(tab);
            Console.WriteLine(string.Join(", ", newTab));

            IncNewTabOut(tab, out int[] incrementedArray);
            Console.WriteLine(string.Join(", ", incrementedArray));
        }
    }
}
