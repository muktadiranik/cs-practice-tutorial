using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Numerics;


namespace C__Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("args[{0}] = {1}", i, args[i]);
            }

            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, intArray[i]);
            }

            string[] stringArray = new string[5] {"Apple", "Orange", "Banana", "Pear", "Grape"};

            for ( int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, stringArray[i]);
            }

            string[] myArgs = Environment.GetCommandLineArgs();

            Console.WriteLine("args = {0}", string.Join(" ", myArgs));

            for (int i = 0; i < myArgs.Length; i++)
            {
                Console.WriteLine("args[{0}] = {1}", i, myArgs[i]);
            }

            Console.WriteLine("addInt({0}, {1}): {2}", 5, 6, addInt(5, 6));
            Console.WriteLine("addString({0}, {1}): {2}", "Hello ", "World!", addString("Hello ", "World!"));
            Console.WriteLine("addDouble({0}, {1}): {2}", 5.5, 6.6, addDouble(5.5, 6.6));
            Console.WriteLine("addDecimal({0}, {1}): {2}", 5.5m, 6.6m, addDecimal(5.5m, 6.6m));


            // datatypes
            int myInt = 5;
            double myDouble = 5.5;
            long myLong = 5L;
            bool myBool = true;
            char myChar = 'a';
            string myString = "Hello World";

            Console.WriteLine("myInt = {0}", myInt);
            Console.WriteLine("myDouble = {0}", myDouble);
            Console.WriteLine("myLong = {0}", myLong);
            Console.WriteLine("myBool = {0}", myBool);
            Console.WriteLine("myChar = {0}", myChar);
            Console.WriteLine("myString = {0}", myString);

            
            // max and min values
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;
            decimal maxDecimal = decimal.MaxValue;
            decimal minDecimal = decimal.MinValue;
            
            Console.WriteLine("maxInt = {0}", maxInt);
            Console.WriteLine("minInt = {0}", minInt);
            Console.WriteLine("maxDouble = {0}", maxDouble);
            Console.WriteLine("minDouble = {0}", minDouble);
            Console.WriteLine("maxLong = {0}", maxLong);
            Console.WriteLine("minLong = {0}", minLong);
            Console.WriteLine("maxFloat = {0}", maxFloat);
            Console.WriteLine("minFloat = {0}", minFloat);
            Console.WriteLine("maxDecimal = {0}", maxDecimal);
            Console.WriteLine("minDecimal = {0}", minDecimal);


            // parse from string
            int intParse = int.Parse("5");
            double doubleParse = double.Parse("5.5");
            long longParse = long.Parse("5");
            float floatParse = float.Parse("5.5");
            decimal decimalParse = decimal.Parse("5.5");
            bool boolParse = bool.Parse("true");
            char charParse = char.Parse("a");

            Console.WriteLine("intParse = {0}", intParse);
            Console.WriteLine("doubleParse = {0}", doubleParse);
            Console.WriteLine("longParse = {0}", longParse);
            Console.WriteLine("floatParse = {0}", floatParse);
            Console.WriteLine("decimalParse = {0}", decimalParse);
            Console.WriteLine("boolParse = {0}", boolParse);
            Console.WriteLine("charParse = {0}", charParse);


            // datetime
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;
            DateTime utcNow = DateTime.UtcNow;
            DateTime utcToday = DateTime.UtcNow.Date;
            DateTime myDate = new DateTime(2019, 10, 1);

            Console.WriteLine("now = {0}", now);
            Console.WriteLine("today = {0}", today);
            Console.WriteLine("utcNow = {0}", utcNow);
            Console.WriteLine("utcToday = {0}", utcToday);
            Console.WriteLine("myDate = {0}", myDate);
            Console.WriteLine("myDate Day of Week = {0}", myDate.DayOfWeek);
            Console.WriteLine("myDate Day of Year = {0}", myDate.DayOfYear);
            Console.WriteLine("myDate Year = {0}", myDate.Year);
            Console.WriteLine("myDate Month = {0}", myDate.Month);
            Console.WriteLine("myDate Day = {0}", myDate.Day);

            myDate = myDate.AddDays(1);
            myDate = myDate.AddMonths(1);
            myDate = myDate.AddYears(1);
            myDate = myDate.AddHours(1);
            myDate = myDate.AddMinutes(1);
            myDate = myDate.AddSeconds(1);
            myDate = myDate.AddMilliseconds(1);
            myDate = myDate.AddTicks(1);

            Console.WriteLine("myDate = {0}", myDate);


            TimeSpan timeSpan = new TimeSpan(12, 30, 50);
            Console.WriteLine("timeSpan = {0}", timeSpan);

            timeSpan = timeSpan.Add(TimeSpan.FromDays(1));
            Console.WriteLine("timeSpan = {0}", timeSpan);

            timeSpan = timeSpan.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("timeSpan = {0}", timeSpan);

            timeSpan = timeSpan.Subtract(new TimeSpan(1, 0, 0));
            Console.WriteLine("timeSpan = {0}", timeSpan);

            Console.WriteLine("timeSpan.Days = {0}", timeSpan.Days);
            Console.WriteLine("timeSpan.Hours = {0}", timeSpan.Hours);
            Console.WriteLine("timeSpan.Minutes = {0}", timeSpan.Minutes);
            Console.WriteLine("timeSpan.Seconds = {0}", timeSpan.Seconds);
            Console.WriteLine("timeSpan.Milliseconds = {0}", timeSpan.Milliseconds);
            Console.WriteLine("timeSpan.Ticks = {0}", timeSpan.Ticks);

            Console.WriteLine("timeSpan to string = {0}", timeSpan.ToString());

            BigInteger bigInteger = BigInteger.Parse("1234567890123456789012345678901234567890");
            Console.WriteLine("bigInteger = {0}", bigInteger);


            // formatting output
            Console.WriteLine("Currency: {0:C}", 123.45);
            Console.WriteLine("Decimal: {0:D}", 123);
            Console.WriteLine("Hexadecimal: {0:X}", 255);
            Console.WriteLine("Number: {0:N}", 1234567890.1234567890);
            Console.WriteLine("Percentage: {0:P}", 0.5);
            Console.WriteLine("Scientific: {0:E}", 123.456);
            Console.WriteLine("General: {0:G}", 123.456);


            // string operation
            string str = "Hello, World!";
            Console.WriteLine("str.Length = {0}", str.Length);
            Console.WriteLine("str.ToLower() = {0}", str.ToLower());
            Console.WriteLine("str.ToUpper() = {0}", str.ToUpper());
            Console.WriteLine("str.Contains(\"World\") = {0}", str.Contains("World"));
            Console.WriteLine("str.IndexOf(\"World\") = {0}", str.IndexOf("World"));
            Console.WriteLine("str.LastIndexOf(\"World\") = {0}", str.LastIndexOf("World"));
            Console.WriteLine("str.Substring(6) = {0}", str.Substring(6));
            Console.WriteLine("str.Substring(6, 5) = {0}", str.Substring(6, 5));
            Console.WriteLine("str.Replace(\"World\", \"C#\") = {0}", str.Replace("World", "C#"));
            Console.WriteLine("str.Insert(6, \"C#\") = {0}", str.Insert(6, "C#"));
            Console.WriteLine("str.Remove(6) = {0}", str.Remove(6));
            Console.WriteLine("str.Remove(6, 3) = {0}", str.Remove(6, 3));
            Console.WriteLine("str.Trim() = {0}", str.Trim());
            Console.WriteLine("str.TrimStart() = {0}", str.TrimStart());
            Console.WriteLine("str.TrimEnd() = {0}", str.TrimEnd());
            Console.WriteLine("str.PadLeft(20) = {0}", str.PadLeft(20));
            Console.WriteLine("str.PadLeft(20, '*') = {0}", str.PadLeft(20, '*'));
            Console.WriteLine("str.PadRight(20) = {0}", str.PadRight(20));
            Console.WriteLine("str.PadRight(20, '*') = {0}", str.PadRight(20, '*'));

            Console.WriteLine(@"str = {0}", str);

        }

        private static int addInt(int x, int y)
        {
            return x + y;
        }

        private static string addString(string x, string y)
        {
            return x + y;
        }

        private static double addDouble(double x, double y)
        {
            return x + y;
        }

        private static decimal addDecimal(decimal x, decimal y)
        {
            return x + y;
        }
    }
}