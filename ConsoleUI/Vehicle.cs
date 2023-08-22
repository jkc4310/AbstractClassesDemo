using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Subaru";
        public string Model { get; set; } = "Forester";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
}

