using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKnowledgeBaseAndTests
{
    /// <summary>
    /// Metody zapisu składni LINQ
    /// </summary>
    class LINQTests
    {
        static void Main(string[] args)
        {
            double[] doubleArray = { 1d, 7.5d, 3.2d, 4.1d, -3.2d, 11d, 2.1d, -6d };

            Console.WriteLine("Składnia zapytania");
            // Składna zapytania
            IEnumerable<double> query = from num in doubleArray where num >= 0 select num;

            foreach (double number in query)
            {
                Console.WriteLine(number.ToString());
            }

            Console.WriteLine("Składnia metody");
            //Składna metody
            IEnumerable<double> query2 = doubleArray.Where(x => x >= 0);

            foreach (double number in query2)
            {
                Console.WriteLine(number.ToString());
            }

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Metoda Sum()
    /// </summary>
    class LINQTests2_Sum
    {        
        static void Main(string[] args)
        {
            double[] doubleArray = { 1d, 7.5d, 3.2d, 4.1d, -3.2d, 11d, 2.1d, -6d };
            Complex[] complexArray = new Complex[10];

            double sum = doubleArray.Sum();
            Console.WriteLine("Suma elementów w tablicy double: {0}", sum.ToString());
            
            double sumRe = complexArray.Sum(x => x.Re);
            Console.WriteLine("Suma elementów Re w tablicy Complex: {0}", sumRe.ToString());
            double sumIm = complexArray.Sum(x => x.Im);
            Console.WriteLine("Suma elementów Im w tablicy Complex: {0}", sumIm.ToString());

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Przeciążenie metody z LINQ - Sum()
    /// </summary>
    static class LINQTests3_SumExtension
    {
        public static double Sum(this IEnumerable<Complex> source)
        {
            return source.Sum(x => x.Re);
        }
        
        static void Main(string[] args)
        {
            Complex[] complexArray = new Complex[10];

            double sum = complexArray.Sum();
            Console.WriteLine("Suma elementów w tablicy double: {0}", sum.ToString());

            Console.ReadLine();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class LINQTests4
    {
        static void Main(string[] args)
        {
            double[] doubleArray = { 1d, 7.5d, 3.2d, 4.1d, -3.2d, 11d, 2.1d, -6d };

            Console.ReadLine();
        }
    }
    
    class Complex
    {
        private static readonly double _min = -100d;
        private static readonly double _max = 100d;
        private static Random _random = new Random();
        public double Im { get; set; }
        public double Re { get; set; }

        public Complex()
        {
            Im = _random.NextDouble() * (_max - _min) + _min;
            Re = _random.NextDouble() * (_max - _min) + _min;
        }

        public Complex(double Re, double Im)
        {
            this.Im = Im;
            this.Re = Re;
        }
    }
}
