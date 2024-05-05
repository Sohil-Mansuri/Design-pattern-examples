using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    internal class Car : Vehicle
    {
        public Car() : base(new NormalDriveStrategy())
        {

        }

    }
}
