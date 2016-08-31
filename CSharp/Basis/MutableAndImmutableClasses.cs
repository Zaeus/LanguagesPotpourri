using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MutableAndImmutableClasses
    {
        class OperatorsOverrideClass
        {
            public int Number1 { get; private set; }
            public int Number2 { get; private set; }

            public OperatorsOverrideClass()
            {
                Number1 = 0;
                Number2 = 0;
            }

            public OperatorsOverrideClass(int Number1, int Number2)
            {
                this.Number1 = Number1;
                this.Number2 = Number2;
            }

            public static bool operator ==(OperatorsOverrideClass oO1, OperatorsOverrideClass oO2)
            {
                return oO1.Number1 == oO2.Number1 && oO1.Number2 == oO2.Number2;
            }

            public static bool operator !=(OperatorsOverrideClass oO1, OperatorsOverrideClass oO2)
            {
                return oO1.Number1 != oO2.Number1 || oO1.Number2 != oO2.Number2;
            }

            public static bool operator >(OperatorsOverrideClass oO1, OperatorsOverrideClass oO2)
            {
                return oO1.Number1 > oO2.Number1 && oO1.Number2 > oO2.Number2;
            }

            public static bool operator <(OperatorsOverrideClass oO1, OperatorsOverrideClass oO2)
            {
                return oO1.Number1 < oO2.Number1 && oO1.Number2 < oO2.Number2;
            }

            public static bool operator >=(OperatorsOverrideClass oO1, OperatorsOverrideClass oO2)
            {
                return oO1.Number1 >= oO2.Number1 && oO1.Number2 >= oO2.Number2;
            }

            public static bool operator <=(OperatorsOverrideClass oO1, OperatorsOverrideClass oO2)
            {
                return oO1.Number1 <= oO2.Number1 && oO1.Number2 <= oO2.Number2;
            }

            public override bool Equals(object obj)
            {
                return ReferenceEquals(this, obj) || (Number1 == ((OperatorsOverrideClass)obj).Number1 && Number2 == ((OperatorsOverrideClass)obj).Number2);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }

        class MutableClass : ICloneable
        {
            public int Number { get; set; }
            public int Age { get; set; }

            public MutableClass()
            {
                Number = 0;
                Age = 10;
            }

            public MutableClass(int Number, int Age)
            {
                this.Number = Number;
                this.Age = Age;
            }

            public MutableClass AddOne()
            {
                Number++;
                Age++;
                return this;
            }

            public MutableClass SubtractOne()
            {
                Number--;
                Age--;
                return this;
            }

            public object Clone()
            {
                return new MutableClass(Number, Age);
            }

            public override bool Equals(object obj)
            {
                return ReferenceEquals(this, obj) || (Age == ((ImmutableClass)obj).Age && Number == ((ImmutableClass)obj).Number);
            }

            public override int GetHashCode()
            {
                return (Number >> 6) ^ (Age >> 16);
            }
        }

        class ImmutableClass : ICloneable
        {
            public int Number { get; private set; }
            public int Age { get; private set; }

            public ImmutableClass()
            {
                Number = 0;
                Age = 10;
            }

            public ImmutableClass(int Number, int Age)
            {
                this.Number = Number;
                this.Age = Age;
            }

            public ImmutableClass AddOne()
            {
                return new ImmutableClass(Number + 1, Age + 1);
            }

            public ImmutableClass SubtractOne()
            {
                return new ImmutableClass(Number - 1, Age - 1);
            }

            public object Clone()
            {
                return new ImmutableClass(Number, Age);
            }
            
            public override bool Equals(object obj)
            {
                return ReferenceEquals(this, obj) || (Age == ((ImmutableClass)obj).Age && Number == ((ImmutableClass)obj).Number);
            }

            public override int GetHashCode()
            {
                return (Number >> 6) ^ (Age >> 16);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("mutable1 =\\= mutable2");
            MutableClass mutable1 = new MutableClass(1, 1);
            MutableClass mutable2 = new MutableClass(1, 1);
            Console.WriteLine("mutable1 == mutable2 before AddOne(): {0}", mutable1 == mutable2);
            mutable1.AddOne();
            Console.WriteLine("mutable1 == mutable2 after AddOne(): {0}", mutable1 == mutable2);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("mutable3 = mutable4");
            MutableClass mutable3 = new MutableClass(1, 1);
            MutableClass mutable4 = mutable3;
            Console.WriteLine("mutable3 == mutable4 before AddOne(): {0}", mutable3 == mutable4);
            mutable3.AddOne();
            Console.WriteLine("mutable3 == mutable4 after AddOne(): {0}", mutable3 == mutable4);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("immutable1 =\\= immutable2");
            ImmutableClass immutable1 = new ImmutableClass(1, 1);
            ImmutableClass immutable2 = new ImmutableClass(1, 1);
            Console.WriteLine("immutable1 == immutable2 before AddOne(): {0}", immutable1 == immutable2);
            immutable1 = immutable1.AddOne();
            Console.WriteLine("immutable1 == immutable2 after AddOne(): {0}", immutable1 == immutable2);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("immutable3 = immutable4");
            ImmutableClass immutable3 = new ImmutableClass(1, 1);
            ImmutableClass immutable4 = immutable3;
            Console.WriteLine("immutable3 == immutable4 before AddOne(): {0}", immutable3 == immutable4);
            immutable3 = immutable3.AddOne();
            Console.WriteLine("immutable3 == immutable4 after AddOne(): {0}", immutable3 == immutable4);

            Console.ReadLine();
        }
    }
}
