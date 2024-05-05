using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    internal class Bike : Vehicle
    {
        // now from here changeing you can change your algorithem
        public Bike() : base(new SportsDriveStrategy())
        {

        }
    }
}
