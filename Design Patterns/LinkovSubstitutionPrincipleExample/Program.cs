using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkovSubstitutionPrincipleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBiKe biKe = GetObject("B"); //Not following Linkov Substitution Principle
            biKe.TurnOnEngine();
            biKe.Accelerate();
        }


        //Factory Pattern
        public static IBiKe GetObject(string name)
        {
            switch (name)
            {
                case "A":
                   return new MotorCycle();
                case "B":
                   return new Bicycle();
                default: return null;
            }
        }

    }
}
