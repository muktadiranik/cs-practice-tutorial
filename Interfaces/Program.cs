using System;

namespace cs_practice_tutorial
{
    interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }
        void Move();
        void Stop();
    }

    interface IElectronicDevice
    {
        void TurnOn();
        void TurnOff();
        void VolumeUp();
        void VolumeDown();
    }

    interface ICommand
    {
        void Execute();
        void Undo();
    }

    class Vehicle : IDrivable
    {
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }

        public Vehicle(string brand = "Default", int wheels = 4, double speed = 0.0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"{Brand} vehicle is moving at {Speed} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} vehicle has stopped.");
            Speed = 0;
        }
    }

    class Television : IElectronicDevice
    {
        public int Volume { get; set; }

        public void TurnOn()
        {
            Console.WriteLine("Television is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Television is turned off.");
        }

        public void VolumeUp()
        {
            Console.WriteLine("Television volume is increased.");
        }

        public void VolumeDown()
        {
            Console.WriteLine("Television volume is decreased.");
        }
    }

    class Command : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Command is executed.");
        }

        public void Undo()
        {
            Console.WriteLine("Command is undone.");
        }
    }

    class PowerButton : ICommand
    {
        IElectronicDevice device;

        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.TurnOn();
        }

        public void Undo()
        {
            device.TurnOff();
        }
    }

    class TelevisionRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Vehicle("Toyota", 4, 120.0);

            if (myCar is IDrivable)
            {
                myCar.Move();
                myCar.Stop();
            }
            else
            {
                Console.WriteLine("Vehicle is not IDrivable.");
            }

            Television myTelevision = new Television();
            if (myTelevision is IElectronicDevice)
            {
                myTelevision.TurnOn();
                myTelevision.VolumeUp();
                myTelevision.VolumeDown();
                myTelevision.TurnOff();
            }
            else
            {
                Console.WriteLine("Television is not IElectronicDevice.");
            }

            Command myCommand = new Command();
            if (myCommand is ICommand)
            {
                myCommand.Execute();
                myCommand.Undo();
            }
            else
            {
                Console.WriteLine("Command is not ICommand.");
            }
        }
    }
}
