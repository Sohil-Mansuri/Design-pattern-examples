using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal class VegDelightPizza : BasePizza
    {
        public override int Cost()
        {
            return 150;
        }
    }
}
