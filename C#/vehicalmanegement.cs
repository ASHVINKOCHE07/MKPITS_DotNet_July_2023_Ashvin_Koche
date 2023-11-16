using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VehicleManagementExample
{
    abstract class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(int id, string make, string model, int year)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
        }

        public abstract double GetRentalPrice();
    }

    class Car : Vehicle
    {
        public int Doors { get; set; }
        public string Color { get; set; }

        public Car(int id, string make, string model, int year, int doors, string color) : base(id, make, model, year)
        {
            Doors = doors;
            Color = color;
        }

        public override double GetRentalPrice()
        {
            double basePrice = base.GetRentalPrice();
            if (Doors == 2)
            {
                return basePrice * 1.2;
            }
            else if (Doors == 4)
            {
                return basePrice * 1.5;
            }
            else
            {
                return basePrice * 2.0;
            }
        }
    }

    class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(int id, string make, string model, int year, bool hasSidecar) : base(id, make, model, year)
        {
            HasSidecar = hasSidecar;
        }

        public override double GetRentalPrice()
        {
            double basePrice = base.GetRentalPrice();
            if (HasSidecar)
            {
                return basePrice * 1.5;
            }
            else
            {
                return basePrice * 2.0;
            }
        }
    }

    class VehicleManagement
    {
        static void Main(string[] args)
        {
            // Create some vehicles
            Car car1 = new Car(1, "Toyota", "Corolla", 2018, 4, "Red");
            Car car2 = new Car(2, "Honda", "Civic", 2019, 4, "Blue");
            Motorcycle motorcycle1 = new Motorcycle(3, "Harley-Davidson", "Sportster", 2017, true);
            Motorcycle motorcycle2 = new Motorcycle(4, "Ducati", "Panigale", 2018, false);

            // Print the rental prices for each vehicle
            Console.WriteLine("Car 1 rental price: $" + car1.GetRentalPrice());
            Console.WriteLine("Car 2 rental price: $" + car2.GetRentalPrice());
            Console.WriteLine("Motorcycle 1 rental price: $" + motorcycle1.GetRentalPrice());
            Console.WriteLine("Motorcycle 2 rental price: $" + motorcycle2.GetRentalPrice());
        }
    }
}
