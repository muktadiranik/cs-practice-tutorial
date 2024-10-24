// This is C# tutorial of contructors properties
// Provide as much examples as possible
using System;
using System.Net.NetworkInformation;


namespace Constructors_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the class
            Animal animal = new Animal();
            animal.Display();
            animal.Validate();

            // Create an object of the class with parameters
            Animal animal1 = new Animal("Dog", 5, "Black");
            animal1.Display();
            animal1.Validate();

            // Create an object of the class with parameters
            Animal animal2 = new Animal(5);
            animal2.Display();
            animal2.Validate();

            // Create an object of the class with parameters
            Animal animal3 = new Animal("Cat", 3);
            animal3.Display();
            animal3.Validate();

            // Create an object of the class with parameters
            Animal animal4 = new Animal();
            animal4.Display();
            animal4.Validate();

            // Set name of the object
            animal4.SetName("Cow");
            animal4.Display();
            animal4.Validate();
            animal4.Color = "Brown";
            animal4.Display();
            animal4.Validate();

            // Get name of the object
            Console.WriteLine(animal4.GetName());

            // Call the Animal count method
            Animal.IncreaseCount();
        }
    }

    // Create a class named Animal
    class Animal
    {
        // Initialize the values of the class
        public string Name { get; set; } = "Animal";
        public int Age { get; set; } = 0;
        public string Color { get; set; } = "White";

        // Declare a public constant
        public const int MAX_AGE = 100;

        // Create a constructor
        public Animal(string name = "Animal", int age = 0, string color = "White")
        {
            Name = name;
            Age = age;
            Color = color;
        }

        // Create a constructor in different approach
        public Animal() : this("Animal", 0, "White") { }

        // Create a constructor in different approach
        public Animal(int age) : this("Animal", age, "White") { }

        // Create a constructor in different approach
        public Animal(string name, int age) : this(name, age, "White") { }

        // Create a method to validate all the values
        public void Validate()
        {
            if (Age > MAX_AGE)
            {
                Console.WriteLine("Age is greater than MAX_AGE");
            }
            else if(Name.Any(char.IsDigit))
            {
                Console.WriteLine("Name contains digit");
            }
            else if (Color.Any(char.IsDigit))
            {
                Console.WriteLine("Color contains digit");
            }
            // Check if the age contains characters
            else if (!Age.ToString().All(char.IsDigit))
            {
                Console.WriteLine("Age contains characters");
            }
            else if (Age < 0)
            {
                Console.WriteLine("Age cannot be negative");
            }
            else {
                Console.WriteLine("All values are valid");
            }
        }


        // Create a getter of this class
        public string GetName()
        {
            return Name;
        }

        // Create a setter of this class
        public void SetName(string name)
        {
            Name = name;
        }

        // Create a method
        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("MAX_AGE: " + MAX_AGE);
        }

        // Create a function of to increase the number of Animal counts

        public static int AnimalCount = 0;

        public static void IncreaseCount()
        {
            AnimalCount++;
            Console.WriteLine("Animal count: " + AnimalCount);
        }
    }
}
