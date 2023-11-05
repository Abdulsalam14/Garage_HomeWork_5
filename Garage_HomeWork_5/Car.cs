using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_5
{
    public class Car
    {
        public string Brend;
        public string Model;
        public int Year;
        public string FuelType;
        public string Color;

        public Car(string brend, string model, int year, string fuelType, string color)
        {
            Brend = brend;
            Model = model;
            Year = year;
            FuelType = fuelType;
            Color = color;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Brend:{Brend}\nModel:{Model}\nYear:{Year}\nFuelType{FuelType}\nColor:{Color}");
        }
    }
}
