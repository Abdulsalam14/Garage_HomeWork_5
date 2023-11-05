using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_5
{
    public class Vehicle
    {
        public string Brend;
        public string Model;
        public int Year;
        public short Maxspeed;

        public Vehicle(string brend, string model, int year, short maxspeed)
        {
            Brend = brend;
            Model = model;
            Year = year;
            Maxspeed = maxspeed;
            Console.WriteLine(maxspeed>110?"Suret Oldurur":"Bele davam edin");
        }
    }
}
