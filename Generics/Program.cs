using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name = "Default")
        {
            Name = name;
        }

        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double doubleNum1 = Convert.ToDouble(num1);
            double doubleNum2 = Convert.ToDouble(num2);
            Console.WriteLine(doubleNum1 + doubleNum2);
        }
    }

    struct Rectangle<T>
    {
        private T width;
        private T height;

        public T Width
        {
            get { return width; }
            set { width = value; }
        }

        public T Height
        {
            get { return height; }
            set { height = value; }
        }

        public Rectangle(T width, T height)
        {
            this.width = width;
            this.height = height;
        }

        public string GetArea()
        {
            double doubleWidth = Convert.ToDouble(width);
            double doubleHeight = Convert.ToDouble(height);
            return (doubleWidth * doubleHeight).ToString();
        }
    }

    public delegate void Arithmetic(double num1, double num2);

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            animals.Add(new Animal("Pig"));
            animals.Add(new Animal("Cow"));
            animals.Add(new Animal("Sheep"));

            animals.Insert(1, new Animal() { Name = "Horse" });

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

            animals.RemoveAt(1);

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

            Console.WriteLine(animals.Count);

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

            int x = 10;
            int y = 20;
            Animal.GetSum<int>(ref x, ref y);

            string s1 = "20";
            string s2 = "50";
            Animal.GetSum<string>(ref s1, ref s2);

            Rectangle<int> rectangle1 = new Rectangle<int>(10, 20);
            Console.WriteLine(rectangle1.GetArea());

            Rectangle<string> rectangle2 = new Rectangle<string>("10", "20");
            Console.WriteLine(rectangle2.GetArea());

            Arithmetic add,
                subtract,
                multiply,
                divide;

            add = new Arithmetic(Program.Add);
            subtract = new Arithmetic(Program.Subtract);
            multiply = new Arithmetic(Program.Multiply);
            divide = new Arithmetic(Program.Divide);

            add(10, 20);
            subtract(10, 20);
            multiply(10, 20);
            divide(10, 20);
        }

        public static void Add(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Multiply(double num1, double num2)
        {
            Console.WriteLine(num1 * num2);
        }

        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine(num1 - num2);
        }

        public static void Divide(double num1, double num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
