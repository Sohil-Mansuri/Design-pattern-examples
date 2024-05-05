using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    internal class AverageDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Average Drive Strategy");
        }
    }
}
