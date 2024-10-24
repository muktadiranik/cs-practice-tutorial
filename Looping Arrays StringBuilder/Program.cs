using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Numerics;
using System.Globalization;


namespace Looping_Arrays_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit typing
            var x = 10;
            Console.WriteLine("x = {0}", x);
            Console.WriteLine("x.GetType() = {0}", x.GetType());


            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };
            string[] stringArray = new string[5] {"Apple", "Orange", "Banana", "Pear", "Grape"};
            double[] doubleArray = new double[5] {1.1, 2.2, 3.3, 4.4, 5.5};
            decimal[] decimalArray = new decimal[5] {1.1m, 2.2m, 3.3m, 4.4m, 5.5m};
            var varArray = new int[5] {1, 2, 3, 4, 5};
            object[] objectArray = new object[5] {"Apple", "Orange", 3.3, 4.4, 5.5};


            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("intArray[{0}] = {1}", i, intArray[i]);
            }

            foreach (string s in stringArray)
            {
                Console.WriteLine("s = {0}", s);
            }

            for (int i = doubleArray.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine("doubleArray[{0}] = {1}", i, doubleArray[i]);
            }

            for (int i = 0; i < decimalArray.Length; i++)
            {
                Console.WriteLine("decimalArray[{0}] = {1}", i, decimalArray[i]);
            }

            for (int i = 0; i < varArray.Length; i++)
            {
                Console.WriteLine("varArray[{0}] = {1}", i, varArray[i]);
            }

            foreach (object o in objectArray)
            {
                Console.WriteLine("o = {0}, {1}", o, o.GetType());
            }

            for (int i = 0; i < objectArray.Length; i++)
            {
                Console.WriteLine("objectArray[{0}] = {1}, {2}", i, objectArray[i], objectArray[i].GetType());
            }


            // multi dimension array
            int[,] multiIntArray = new int[5, 5] {{1, 2, 3, 4, 5}, {6, 7, 8, 9, 10}, {11, 12, 13, 14, 15}, {16, 17, 18, 19, 20}, {21, 22, 23, 24, 25}};
            
            for (int i = 0; i < multiIntArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiIntArray.GetLength(1); j++)
                {
                    Console.WriteLine("multiIntArray[{0},{1}] = {2}", i, j, multiIntArray[i, j]);
                }
            }

            // print multi dimensional array in pattern

            for (int i = 0; i < multiIntArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiIntArray.GetLength(1); j++)
                {
                    Console.Write("{0} ", multiIntArray[i, j]);
                }
                Console.WriteLine();
            }

            string[,] multiStringArray = new string[5, 5] {{"A", "B", "C", "D", "E"}, {"F", "G", "H", "I", "J"}, {"K", "L", "M", "N", "O"}, {"P", "Q", "R", "S", "T"}, {"U", "V", "W", "X", "Y"}};

            for (int i = 0; i < multiStringArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiStringArray.GetLength(1); j++)
                {
                    Console.WriteLine("multiStringArray[{0},{1}] = {2}", i, j, multiStringArray[i, j]);
                }
            }

            for (int i = 0; i < multiStringArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiStringArray.GetLength(1); j++)
                {
                    Console.Write("{0} ", multiStringArray[i, j]);
                }
                Console.WriteLine();
            }

            Array.Sort(intArray);
            
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("intArray[{0}] = {1}", i, intArray[i]);
            }

            Array.Reverse(intArray);
            
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("intArray[{0}] = {1}", i, intArray[i]);
            }


            // array operation

            int[] intArray2 = new int[5] {1, 2, 3, 4, 5};
            int[] intArray3 = new int[5] {6, 7, 8, 9, 10};

            intArray2 = intArray2.Concat(intArray3).ToArray();
            for (int i = 0; i < intArray2.Length; i++)
            {
                Console.WriteLine("intArray2[{0}] = {1}", i, intArray2[i]);
            }
            
            Console.WriteLine("intArray2.Length = {0}", intArray2.Length);
            Console.WriteLine("intArray2.Rank = {0}", intArray2.Rank);
            Console.WriteLine("intArray2.GetLowerBound(0) = {0}", intArray2.GetLowerBound(0));
            Console.WriteLine("intArray2.GetUpperBound(0) = {0}", intArray2.GetUpperBound(0));
            Console.WriteLine("intArray2.GetLongLength(0) = {0}", intArray2.GetLongLength(0));
            Console.WriteLine("intArray2.GetType() = {0}", intArray2.GetType());
            Console.WriteLine("intArray2.IsFixedSize = {0}", intArray2.IsFixedSize);
            Console.WriteLine("intArray2.IsReadOnly = {0}", intArray2.IsReadOnly);
            Console.WriteLine("intArray2.IsSynchronized = {0}", intArray2.IsSynchronized);
            Console.WriteLine("intArray2.SyncRoot = {0}", intArray2.SyncRoot);
            Console.WriteLine("intArray2.Clone() = {0}", intArray2.Clone());
            Console.WriteLine("intArray2.GetEnumerator() = {0}", intArray2.GetEnumerator());
            Console.WriteLine("Array.IndexOf(intArray2, 5) = {0}", Array.IndexOf(intArray2, 5));
            Console.WriteLine("Array.LastIndexOf(intArray2, 5) = {0}", Array.LastIndexOf(intArray2, 5));

            // set value of array
            intArray2[0] = 100;
            Console.WriteLine("intArray2[0] = {0}", intArray2[0]);

            // copy array
            int[] intArray4 = new int[5] {1, 2, 3, 4, 5};
            int[] intArray5 = new int[5] {6, 7, 8, 9, 10};

            intArray4.CopyTo(intArray5, 0);
            Console.WriteLine("intArray5[0] = {0}", intArray5[0]);

            int[] sourceArray = new int[5] {1, 2, 3, 4, 5};
            int[] targetArray = new int[5];
            int startIndex = 0;
            int length = sourceArray.Length;

            Array.Copy(sourceArray, startIndex, targetArray, startIndex, length);
            
            for (int i = 0; i < targetArray.Length; i++)
            {
                Console.WriteLine("targetArray[{0}] = {1}", i, targetArray[i]);
            }

            Array targetArray2 = Array.CreateInstance(typeof(int), 5);

            sourceArray.CopyTo(targetArray2, 0);
            
            for (int i = 0; i < targetArray2.Length; i++)
            {
                Console.WriteLine("targetArray2[{0}] = {1}", i, targetArray2.GetValue(i));
            }

            int count = 0;
            foreach (int item in targetArray2)
            {
                Console.WriteLine("targetArray2[{0}] = {1}", count, item);
                count++;
            }


            // predicate function
            int[] intArray6 = { 2, 5, 8, 1, 7 };

            // find all even numbers using the predicate
            var evenNumbers = Array.FindAll(intArray6, isEven);

            foreach (int num in evenNumbers)
            {
                Console.WriteLine("Even numbers: {0}", num);
            }

            Console.WriteLine("greaterThan: {0}", Array.Find(intArray6, x => greaterThan(x, 5)));


            // string builder

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World!");
            Console.WriteLine("sb.ToString() = {0}", sb.ToString());
            sb.AppendLine("Hello World!");
            Console.WriteLine("sb.ToString() = {0}", sb.ToString());

            // string builder function

            StringBuilder sb2 = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                sb2.Append(i);
            }
            Console.WriteLine(sb2.ToString());

            StringBuilder sb3 = sb.Append("Hello");
            Console.WriteLine(sb3.ToString());

            Console.WriteLine("sb.Capacity = {0}", sb.Capacity);
            Console.WriteLine("sb.MaxCapacity = {0}", sb.MaxCapacity);
            Console.WriteLine("sb.Length = {0}", sb.Length);

            // globalization

            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("CultureInfo.CurrentCulture.Name = {0}", CultureInfo.CurrentCulture.Name);

            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            Console.WriteLine("enUS.Name = {0}", enUS.Name);

            StringBuilder sb4 = new StringBuilder();
            string randomString = "Bob Smith";
            sb4.AppendFormat(enUS, "Hello {0}", randomString);
            Console.WriteLine(sb4.ToString());

            sb4.Replace("Hello", "Hi");
            Console.WriteLine("sb4.ToString() = {0}", sb4.ToString());

            Console.WriteLine("sb4.ToString().Length = {0}", sb4.ToString().Length);
            Console.WriteLine("sb.Equals(sb4) = {0}", sb.Equals(sb4));

            sb4.Insert(0, "Hello ");
            Console.WriteLine("sb4.ToString() = {0}", sb4.ToString());

            sb4.Remove(0, 5);
            Console.WriteLine("sb4.ToString() = {0}", sb4.ToString());

            // type casting
            long longValue = 100;
            Console.WriteLine("longValue = {0}, {1}", longValue, longValue.GetType());
            int intValue = (int)longValue;
            Console.WriteLine("intValue = {0}, {1}", intValue, intValue.GetType());
            double doubleValue = (double)longValue;
            Console.WriteLine("doubleValue = {0}, {1}", doubleValue, doubleValue.GetType());
            float floatValue = (float)longValue;
            Console.WriteLine("floatValue = {0}, {1}", floatValue, floatValue.GetType());

        }

        private static bool isEven(int num)
        {
            return num % 2 == 0;
        }

        private static bool greaterThan(int value, int limit)
        {
            return value > limit;
        }
    }
}
