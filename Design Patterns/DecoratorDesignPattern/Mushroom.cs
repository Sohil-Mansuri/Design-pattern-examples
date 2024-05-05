using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal class Mushroom : ToppingDecorator
    {
        BasePizza _basePizza;
        private int _mushroomPrice = 30;

        public Mushroom(BasePizza basePizza)
        {
            _basePizza = basePizza;
        }
        public override int Cost()
        {
            return _basePizza.Cost() + _mushroomPrice;
        }
    }
}
