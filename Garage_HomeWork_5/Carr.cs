using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_5
{
    public class Carr : Vehicle
    {
        public byte NumSeats;
        public Carr(string brend, string model, int year, short maxspeed, byte numSeats) : base(brend, model, year, maxspeed)
        {
            NumSeats = numSeats;
        }
    }
}
