using System;

namespace Interfaces
{

    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vroom! Vroom!");
        }
    }

    class Program
    {

        public class Zero : Vehicle
        { // Electric motorcycle
            public double BatteryKWh { get; set; }

            public void ChargeBattery() { }

            public override void Drive()
            {
                Console.WriteLine("shhhhhhhummmmm!");
            }
        }
        public class Cessna : Vehicle
        { // Propellor light aircraft
            public double FuelCapacity { get; set; }

            public void RefuelTank() { }
        }
        public class Mazda : Vehicle
        { // Propellor light aircraft
            public double FuelCapacity { get; set; }

            public void RefuelTank() { }

            public override void Drive()
            {
                Console.WriteLine("Zoom Zoom");
            }
        }
        public class Tesla : Vehicle
        { // Electric car
            public double BatteryKWh { get; set; }

            public void ChargeBattery() { }

            public override void Drive()
            {
                Console.WriteLine("zzzzzzZZZZZZZZzzzz");
            }
        }
        public class Ram : Vehicle
        { // Gas powered truck
            public double FuelCapacity { get; set; }

            public void RefuelTank() { }
        }
        static void Main(string[] args)
        {
            var zero = new Zero();
            var tesla = new Tesla();
            var cessna = new Cessna();
            var ram = new Ram();
            var mazda = new Mazda();

            zero.MainColor = "White";
            tesla.MaximumOccupancy = 5;

            zero.Drive();
            tesla.Drive();
            cessna.Drive();
            ram.Drive();
            mazda.Drive();
        }
    }
}