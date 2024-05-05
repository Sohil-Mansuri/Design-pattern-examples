using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkovSubstitutionPrincipleExample
{
    public class Bicycle : IBiKe
    {
        public void Accelerate()
        {
            //Accelerate 
        }

        public void TurnOnEngine()
        {
            throw new Exception("Bicycle does not have engine");
        }
    }
}
