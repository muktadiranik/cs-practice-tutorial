// This is a C# tutorial of classes and OOP
// Give much examples as possible
using System;

namespace Classes_and_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set random values to the width and height of the rectangle and print all the values

            Random rand = new Random();
            Rectangle rect = new Rectangle();
            rect.Width = rand.Next(1, 10);
            rect.Height = rand.Next(1, 10);
            Console.WriteLine("Rectangle Width: {0}", rect.Width);
            Console.WriteLine("Rectangle Height: {0}", rect.Height);
            Console.WriteLine("Rectangle Area: {0}", rect.Area());

            // Create a rectangle using constructor and print all the values

            Rectangle rect2 = new Rectangle(5, 10);
            Console.WriteLine("Rectangle Width: {0}", rect2.Width);
            Console.WriteLine("Rectangle Height: {0}", rect2.Height);
            Console.WriteLine("Rectangle Area: {0}", rect2.Area());

            // Create an instance of the Animal class and print all the values

            Animal animal = new Animal();
            animal.Name = "Lion";
            animal.Age = 5;
            animal.Habitat = "Africa";
            Console.WriteLine("Animal Name: {0}", animal.Name);
            Console.WriteLine("Animal Age: {0}", animal.Age);
            Console.WriteLine("Animal Habitat: {0}", animal.Habitat);
            animal.Move();
            animal.Eat();
            animal.Sleep();

            // Create an instance of the Animal class using constructor and print all the values

            Animal animal2 = new Animal("Lion", 5, "Africa");
            Console.WriteLine("Animal Name: {0}", animal2.Name);
            Console.WriteLine("Animal Age: {0}", animal2.Age);
            Console.WriteLine("Animal Habitat: {0}", animal2.Habitat);
            animal2.Move();
            animal2.Eat();
            animal2.Sleep();

            // Print the values of the animal using ToString()

            Console.WriteLine("Animal: {0}", animal);
            Console.WriteLine("Animal: {0}", animal.ToString());

            // Call the functions of the Dog class

            Dog dog = new Dog();
            dog.Bark();
            dog.Move();
            dog.Eat();
            dog.Sleep();
            dog.ToString();

            // Create a new dog instance and print all the values

            Dog dog2 = new Dog("Rex", 5, "Africa");
            Console.WriteLine("Dog Name: {0}", dog2.Name);
            Console.WriteLine("Dog Age: {0}", dog2.Age);
            Console.WriteLine("Dog Habitat: {0}", dog2.Habitat);
            dog2.Bark();
            dog2.Move();
            dog2.Eat();
            dog2.Sleep();
            dog2.ToString();
        }
    }

    struct Rectangle
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }
    }

    // Create a class with properties and methods named Animal
    class Animal
    {
        public string Name;
        public int Age;
        public string Habitat;

        public Animal(string name = "Unknown", int age = 0, string habitat = "Unknown")
        {
            Name = name;
            Age = age;
            Habitat = habitat;
        }

        public void Move()
        {
            Console.WriteLine("The animal is moving");
        }
        public void Eat()
        {
            Console.WriteLine("The animal is eating");
        }
        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping");
        }

        // Return the values passed to the constructor
        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + ", Habitat: " + Habitat;
        }
    }

    // Create a class extending the Animal class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog is barking");
        }

        // Create a constructor of that class
        public Dog(string name = "Unknown", int age = 0, string habitat = "Unknown")
        {
            Name = name;
            Age = age;
            Habitat = habitat;
        }
    }
}