﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    internal class FarmhousePIzza : BasePizza
    {
        public override int Cost()
        {
            return 100;
        }
    }
}
