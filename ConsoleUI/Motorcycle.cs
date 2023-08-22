using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}

        public bool HasSideCar { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is in drive.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType} that is virtually in drive");
        }
    }
}

