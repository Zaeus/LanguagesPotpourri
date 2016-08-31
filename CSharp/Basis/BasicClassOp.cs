using System;

namespace Basis
{
    class BasicClassOp : ICloneable
    {
        public int IntNumber { get; private set; }
        public double DoubleNumber { get; private set; }
        public float FloatNumber { get; private set; }
        public decimal DecimalNumber { get; private set; }

        public BasicClassOp()
        {
            IntNumber = 10;
            DoubleNumber = -10d;
            FloatNumber = -5f;
            DecimalNumber = 5m;
        }

        public BasicClassOp(int IntNumber, double DoubleNumber, float FloatNumber, decimal DecimalNumber)
        {
            this.IntNumber = IntNumber;
            this.DoubleNumber = DoubleNumber;
            this.FloatNumber = FloatNumber;
            this.DecimalNumber = DecimalNumber;
        }
        
        public static BasicClassOp operator +(BasicClassOp inst1, BasicClassOp inst2)
        {
            BasicClassOp _basicClassOp = new BasicClassOp(inst1.IntNumber + inst2.IntNumber, inst1.DoubleNumber + inst2.DoubleNumber,
                inst1.FloatNumber + inst2.FloatNumber, inst1.DecimalNumber + inst2.DecimalNumber);
            return _basicClassOp;
        }

        public static BasicClassOp operator -(BasicClassOp inst1, BasicClassOp inst2)
        {
            BasicClassOp _basicClassOp = new BasicClassOp(inst1.IntNumber - inst2.IntNumber, inst1.DoubleNumber - inst2.DoubleNumber,
                inst1.FloatNumber - inst2.FloatNumber, inst1.DecimalNumber + inst2.DecimalNumber);
            return _basicClassOp;
        }

        public static BasicClassOp operator *(BasicClassOp inst1, BasicClassOp inst2)
        {
            BasicClassOp _basicClassOp = new BasicClassOp(inst1.IntNumber * inst2.IntNumber, inst1.DoubleNumber * inst2.DoubleNumber,
                inst1.FloatNumber * inst2.FloatNumber, inst1.DecimalNumber * inst2.DecimalNumber);
            return _basicClassOp;
        }

        public static BasicClassOp operator /(BasicClassOp inst1, BasicClassOp inst2)
        {
            BasicClassOp _basicClassOp = new BasicClassOp(inst1.IntNumber / inst2.IntNumber, inst1.DoubleNumber / inst2.DoubleNumber,
                inst1.FloatNumber / inst2.FloatNumber, inst1.DecimalNumber / inst2.DecimalNumber);
            return _basicClassOp;
        }

        public object Clone()
        {
            BasicClassOp _basicClassOp = new BasicClassOp(IntNumber, DoubleNumber, FloatNumber, DecimalNumber);
            return _basicClassOp;
        }

        public override string ToString()
        {
            return "IntNumber: " + IntNumber.ToString() + ", DoubleNumber:" + DoubleNumber.ToString() 
                + ", FloatNumber:" + FloatNumber.ToString() + ", DecimalNumber:" + DecimalNumber.ToString();
        }

        static void Main(string[] args)
        {
            BasicClassOp basisClassOp1 = new BasicClassOp(100, 10d, -9.5f, -10.2m);
            BasicClassOp basisClassOp2 = new BasicClassOp(10, 100d, -100f, -100.1m);
            BasicClassOp basisClassOpSum = basisClassOp1 + basisClassOp2;
            BasicClassOp basisClassOpSub = basisClassOp1 - basisClassOp2;
            BasicClassOp basisClassOpMul = basisClassOp1 * basisClassOp2;
            BasicClassOp basisClassOpDiv = basisClassOp1 / basisClassOp2;

            Console.WriteLine("Podstawowe operacje matematyczne zaimplementowane dla BasicClassOp");
            Console.WriteLine("basisClassOp1: {0}", basisClassOp1.ToString());
            Console.WriteLine("basisClassOp2: {0}", basisClassOp2.ToString());
            Console.WriteLine("Suma basisClassOp1 i basisClassOp2: {0}", basisClassOpSum.ToString());
            Console.WriteLine("Różnica basisClassOp1 i basisClassOp2: {0}", basisClassOpSub.ToString());
            Console.WriteLine("Iloczyn basisClassOp1 i basisClassOp2: {0}", basisClassOpMul.ToString());
            Console.WriteLine("Iloraz basisClassOp1 i basisClassOp2: {0}", basisClassOpDiv.ToString());

            Console.ReadLine();
        }
    }
}
