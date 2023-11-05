using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_5
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar;
        public Motorcycle(string brend, string model, int year, short maxspeed, bool hasSideCar) : base(brend, model, year, maxspeed)
        {
            HasSideCar = hasSideCar;
        }
    }
}
