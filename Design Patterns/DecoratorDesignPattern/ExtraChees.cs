using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal class ExtraChees : ToppingDecorator
    {
        BasePizza _basePizza;
        private int _extraCheesPrice = 20;

        public ExtraChees(BasePizza basePizza)
        {
            _basePizza = basePizza;
        }
        public override int Cost()
        {
            return _basePizza.Cost() + _extraCheesPrice;
        }
    }
}
