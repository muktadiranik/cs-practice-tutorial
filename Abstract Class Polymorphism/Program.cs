using System;

namespace Abstract_Class_Polymorphism
{
    abstract class Shape
    {
        public string Name { get; set; } = "";

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public abstract double Area();
    }

    class Circle : Shape
    {
        public double Radius { get; set; } = 0;

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Radius: {Radius}");
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; } = 0;
        public double Width { get; set; } = 0;

        public Rectangle(double length, double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(5, 10) };
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"Area: {shape.Area()}");
                Console.WriteLine();

                Circle? testCircle = shape as Circle;
                if (testCircle != null)
                {
                    Console.WriteLine($"Circle Radius: {testCircle.Radius}");
                }

                if (shape is Circle)
                {
                    Console.WriteLine("This is not a rectangle");
                }
            }

            object circle = new Circle(5);
            object rectangle = new Rectangle(5, 10);
            Console.WriteLine(circle.GetType());
            Console.WriteLine(rectangle.GetType());

            Circle circle1 = (Circle)circle;
            Rectangle rectangle1 = (Rectangle)rectangle;
            Console.WriteLine(circle1.Radius);
            Console.WriteLine(rectangle1.Length);

            Console.WriteLine($"{circle1.Area()} {rectangle1.Area()}");
            Console.WriteLine($"{circle1.GetType()} {rectangle1.GetType()}");
        }
    }
}
