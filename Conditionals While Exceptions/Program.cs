using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Numerics;
using System.Globalization;
using System.IO.Compression;


namespace Conditionals_While_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // if else

            int x = 10;

            if (x == 10)
            {
                Console.WriteLine("x = 10");
            }
            else
            {
                Console.WriteLine("x != 10");
            }

            // else if

            if (x == 10)
            {
                Console.WriteLine("x = 10");
            }
            else if (x == 20)
            {
                Console.WriteLine("x = 20");
            }
            else
            {
                Console.WriteLine("x != 10 && x != 20");
            }

            // ternary operator

            Console.WriteLine(x == 10 ? "x = 10" : "x != 10");

            // switch

            switch (x)
            {
                case 10:
                    Console.WriteLine("x = 10");
                    break;

                case 20:
                    Console.WriteLine("x = 20");
                    break;

                default:
                    Console.WriteLine("x != 10 && x != 20");
                    break;
            }

            int y = 20;

            switch (y)
            {
                case 10:
                    Console.WriteLine("y = 10");
                    break;

                case 20:
                    Console.WriteLine("y = 20");
                    break;

                default:
                    Console.WriteLine("y != 10 && y != 20");
                    goto z;
            }

            z:
            Console.WriteLine("y != 10 && y != 20");

            string str = "Hello";
            string str2 = "World";

            if (str.Equals(str2, StringComparison.Ordinal))
            {
                Console.WriteLine("str = str2");
            } else if (str.Equals(str2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("str = str2");
            } else 
            {
                Console.WriteLine("str != str2");
            }


            // while

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("i = {0}", i);
                i++;
            }


            // do while

            i = 0;
            do
            {
                Console.WriteLine("i = {0}", i);
                i++;
            } while (i < 5);

            // print odd number using while loop

            i = 0;

            while (i < 10)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("i = {0}", i);
                }

                i++;
            }

            i = 0;

            while (i < 10)
            {
                if (i == 5) 
                {
                    break;
                }
                Console.WriteLine("i = {0}", i);
                i++;
            }

            i = 0;

            do 
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine("i = {0}", i);
                i++;
            } while (i < 10);

            // user input

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num = {0}", num);

            // exceptions

            try
            {
                Console.Write("Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("num = {0}", num);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
                Console.WriteLine("Stack Trace: {0}", e.StackTrace);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Target Site: {0}", e.TargetSite);
                Console.WriteLine("Inner Exception: {0}", e.InnerException);
                Console.WriteLine("Data: {0}", e.Data);
                Console.WriteLine("Help Link: {0}", e.HelpLink);
                Console.WriteLine("HResult: {0}", e.HResult);
                Console.WriteLine("Message: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }

        }
    }
}