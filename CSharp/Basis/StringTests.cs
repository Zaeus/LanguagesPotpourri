using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basis
{
    class StringTests
    {
        static void Main(string[] args)
        {
            StringTest1_ReferenceEquality();
            StringTest2_Immutable();
            StringTest3_IsNullOrEmpty();

            Console.ReadLine();
        }

        /// <summary>
        /// Deklaracja 2 string mających tą samą wartość
        /// </summary>
        public static void StringTest1_ReferenceEquality()
        {
            Console.WriteLine("StringTest1_ReferenceEquality():");

            string str1 = "Test";
            string str2 = "Test";
            string str3 = "Tests";

            // Taki sam string (str1 i str2) mimo że był zadeklarowany osobno powinien mieć tą samą referencję
            Console.WriteLine("str1 = {0}, str2 = {1}, str3 = {2}", str1, str2, str3);
            Console.WriteLine("str1.Equals(str2) = {0}", str1.Equals(str2));
            Console.WriteLine("string.ReferenceEquals(str1, str2) = {0}", ReferenceEquals(str1, str2));
            Console.WriteLine("str1.Equals(str3) = {0}", str1.Equals(str2));
            Console.WriteLine("string.ReferenceEquals(str1, str3) = {0}", ReferenceEquals(str1, str2));

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        public static void StringTest2_Immutable()
        {
            Console.WriteLine("StringTest2_Immutable():");

            string str1 = "Test1";
            string str2 = string.Empty;

            str2 = str1 + "2";

            // Obiekt po zmiane ma całkiem inną referencję
            Console.WriteLine("string.ReferenceEquals(str1, str2) = {0}", ReferenceEquals(str1, str2));

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        public static void StringTest3_IsNullOrEmpty()
        {
            Console.WriteLine("StringTest3_IsNullOrEmpty():");

            string str1 = "Test1";
            string str2 = string.Empty;
            string str3 = null;

            // Sprawdzenie czy string jest null lub jest pusty
            Console.WriteLine("string.IsNullOrEmpty(str1) = {0}", string.IsNullOrEmpty(str1));
            Console.WriteLine("string.IsNullOrEmpty(str2) = {0}", string.IsNullOrEmpty(str2));
            Console.WriteLine("string.IsNullOrEmpty(str1) = {0}", string.IsNullOrEmpty(str3));

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        public static void StringTest4_StringBuilder()
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }
    }
}
