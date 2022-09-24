using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing
{
    internal class Bus : Car
    {
        public Bus(string name, int maxSpeed) : base(maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }
    }
}
