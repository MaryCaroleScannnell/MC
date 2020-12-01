using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Class
{
    public enum VehicleType
    {
        Car, Truck, Van, Spaceship
    }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
    }
    public class Cookie
    {
        public Cookie()
        { }
        public string Name { get; set; }
        public bool HasNuts { get; set; }
        public double GramsOfFlour { get; set; }
        public Cookie (string name, bool hasNuts, double gramsOfFlour)
        {
            Name = name;
            HasNuts = hasNuts;
            GramsOfFlour = gramsOfFlour;
        }
    }
    public class Order
    {
        public string CustomerName { get; set; }
        public Cookie OrderProduct { get; set; }
        public decimal TotalCost { get; set; }
    }
}
