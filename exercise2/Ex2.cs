using System;

namespace exercise2
{
    internal class Program
    {
        public double a, b, c, delta, x1, x2;
        public Program(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.delta = Math.Pow(b, 2) - 4 * a * c;
            this.x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            this.x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        }
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Entrer la valeur de A: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Entrer une valeur valide pour A: ");
            }
            Console.WriteLine("Entrer la valeur de B: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Entrer une valeur valide pour B: ");
            }
            Console.WriteLine("Entrer la valeur de C: ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Entrer une valeur valide pour C: ");
            }

            Program equation = new Program(a, b, c);

            if (equation.delta > 0)
            {
                Console.WriteLine("Deux solutions: x1 = {0}, x2 = {1}", equation.x1, equation.x2);
            }
            else if (equation.delta == 0)
            {
                Console.WriteLine("Une solution: x = {0}", equation.x1);
            }
            else
            {
                Console.WriteLine("Pas de solutions reelles");
            }

        }
    }
}