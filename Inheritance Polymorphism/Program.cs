using System;

namespace Inheritance_Polymorphism
{
    // Create a class called AnimalIdInfo that provides is a relationship between the Animal class and the Dog class
    class AnimalIdInfo
    {
        public int Id { get; set; } = 0;
        public string name { get; set; } = "Unknown";
        public int age { get; set; } = 0;
    }

    // Create a class called Animal with private and protected fields and methods
    class Animal
    {
        private string _name;
        protected int _age;

        protected AnimalIdInfo animalIdInfo = new AnimalIdInfo();

        public void SetAnimalIdInfo(int Id)
        {
            animalIdInfo.Id = Id;
            animalIdInfo.age = _age;
            animalIdInfo.name = _name;
        }

        public void GetAnimalIdInfo()
        {
            Console.WriteLine($"{_name} is {_age} years old and has an id of {animalIdInfo.Id}");
        }

        public void Eat()
        {
            Console.WriteLine($"{_name} is eating and is {_age} years old");
        }

        public void Sleep()
        {
            Console.WriteLine($"{_name} is sleeping and is {_age} years old");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{_name} is moving and is {_age} years old");
        }

        public Animal()
            : this("Default", 0) { }

        public Animal(string name)
            : this(name, 0) { }

        public Animal(int age)
            : this("Default", age) { }

        public Animal(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Invalid name");
                    _name = "Default";
                }
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Invalid age");
                    _age = 0;
                }
            }
        }

        // Create an inner class called AnimalHealth
        public class AnimalHealth
        {
            public int Temperature { get; set; } = 0;
            public int HeartRate { get; set; } = 0;
            public int BloodPressure { get; set; } = 0;

            // Create a method called AnimalHealthInfo
            public void AnimalHealthInfo(int Temperature, int HeartRate, int BloodPressure)
            {
                AnimalHealth animalHealth = new AnimalHealth();

                animalHealth.Temperature = Temperature;
                animalHealth.HeartRate = HeartRate;
                animalHealth.BloodPressure = BloodPressure;

                Console.WriteLine(
                    $"Temperature: {animalHealth.Temperature} HeartRate: {animalHealth.HeartRate} BloodPressure: {animalHealth.BloodPressure}"
                );
            }
        }
    }

    // Create a class called Dog that inherits from the Animal class
    class Dog : Animal
    {
        public Dog()
            : base() { }

        public Dog(string name)
            : base(name) { }

        public Dog(int age)
            : base(age) { }

        public Dog(string name, int age)
            : base(name, age) { }

        // Inherit all the properties from Animal
        public Dog(string name, int age, string breed)
            : base(name, age)
        {
            this.breed = breed;
        }

        public string name { get; set; } = "Unknown";
        public int age { get; set; } = 0;
        public string breed { get; set; } = "Unknown";

        // Create a method called MakeSound
        public void Info()
        {
            Console.WriteLine($"{name} is a {breed} and is {age} years old");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Animal class
            Animal animal = new Animal();
            animal.Eat();

            // Create an instance of the Animal class
            Animal animal1 = new Animal("Lion");
            animal1.Eat();

            // Create an instance of the Animal class
            Animal animal2 = new Animal(5);
            animal2.Eat();

            // Create an instance of the Animal class in another approach
            Animal animal3 = new Animal { Name = "Lion", Age = 5 };
            animal3.Eat();

            // Create an instance of the Dog class
            Dog dog = new Dog();
            dog.Eat();

            // Create an instance of the Dog class
            Dog dog1 = new Dog("Rex");
            dog1.Eat();

            // Create an instance of the Dog class
            Dog dog2 = new Dog(3);
            dog2.Eat();
            dog2.Info();

            // Create an instance of the Dog class
            Dog dog3 = new Dog("Rex", 3);
            dog3.Eat();
            dog3.Info();

            // Create an instance of the Dog class
            Dog dog4 = new Dog("Rex", 3, "Labrador");
            dog4.Eat();
            dog4.Info();

            // Create an instance of Dog class in another approach
            Dog dog5 = new Dog
            {
                name = "Rex",
                age = 3,
                breed = "Labrador",
            };
            dog5.Eat();
            dog5.Info();

            dog5.Name = "Rex";
            dog5.Age = 3;
            dog5.breed = "Labrador";
            dog5.Eat();
            dog5.Info();
            dog5.SetAnimalIdInfo(1);
            dog5.GetAnimalIdInfo();

            // Create an instance of the inner AnimalHealth class
            Animal.AnimalHealth animalHealth = new Animal.AnimalHealth();
            animalHealth.AnimalHealthInfo(0, 0, 0);
            animalHealth.AnimalHealthInfo(36, 80, 120);

            // Polymorphism
            Animal animal6 = new Dog("Rex", 3, "Labrador");
            animal6.Eat();
            animal6.Sleep();

            Dog dog6 = new Dog(name: "Rex", age: 3, breed: "Labrador");
            dog6.Eat();
            dog6.Sleep();
            dog6.Move();
        }
    }
}
