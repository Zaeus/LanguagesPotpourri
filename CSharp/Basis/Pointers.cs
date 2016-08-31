using System;

namespace Basis
{
    class Pointers
    {
        static void Main(string[] args)
        {
            unsafe
            {
                float[] floatArray = new float[] { -5, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                PointerTest1_PointerDeclarationAndAdress();
                PointerTest2_PointerInitialization();
                PointerTest3_PointerOperation();
                PointerTest4_PointerToArray(floatArray);
            }

            Console.ReadLine();
        }

        public static unsafe void PointerTest1_PointerDeclarationAndAdress()
        {
            int intValue = 8;
            int* intPointer = &intValue;

            Console.WriteLine("Odczytanie wartości przez wskaźnik: {0}", (*intPointer).ToString());
            Console.WriteLine("Adres: {0}", (int)intPointer);
        }

        public static unsafe void PointerTest2_PointerInitialization()
        {
            int number;
            int* pointer = &number;

            Console.WriteLine("Wartość number przed inicjalizacją: {0}", number);

            *pointer = 0xffff;

            Console.WriteLine("Wartość number po inicjalizacji: {0}", number);
        }

        public static unsafe void PointerTest3_PointerOperation()
        {
            double* doublePointer;
            double doubleValue = 9.1d;

            Console.WriteLine("Wartość doubleValue przed operacją na wskaźnikach: {0}", doubleValue);

            doublePointer = &doubleValue;
            *doublePointer += *doublePointer;

            Console.WriteLine("Wartość doubleValue po operacji na wskaźnikach: {0}", doubleValue);
        }

        public static unsafe void PointerTest4_PointerToArray(float[] floatArray)
        {
            fixed (float* floatPointer = floatArray)
            {
                float* inFixedPointer = floatPointer;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine((*inFixedPointer).ToString());
                    inFixedPointer++;
                }
            }
        }
    }
}
