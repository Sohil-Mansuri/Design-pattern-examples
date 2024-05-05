using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    internal class NormalDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("NormalDrive called");
        }
    }
}
