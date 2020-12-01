using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Class
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "sinkerdoodle";
            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something Else";

            Cookie snickerdoodle = new Cookie("snickerdoodle", false, 11.5);
            Cookie newCookie = new Cookie("peanut butter", true, 150);
        }
        [TestMethod]
        public void VehicleTest()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            Vehicle newCar = new Vehicle
            {
                TypeOfVehicle = VehicleType.Car,
                Make="Honda",
                Model= "Civic",
            };
        }
    }
}
