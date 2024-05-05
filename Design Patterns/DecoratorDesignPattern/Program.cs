using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    //Pizza shop
    internal class Program
    {
        static void Main(string[] args)
        {
            //margheritaPizza
            BasePizza margheritaPizza = new MargheritaPizza();
            Console.WriteLine("MargeritaPizza Price "+ margheritaPizza.Cost());

            //martheritaPizza with extra cheese
            BasePizza martheritaPizzaWithExtraCheese = new ExtraChees(new MargheritaPizza());
            Console.WriteLine("margheritawith extra cheese " + martheritaPizzaWithExtraCheese.Cost());

            //farmHouse pizze
            BasePizza farmhousePizza = new FarmhousePIzza();
            Console.WriteLine("farmhouse Pizza " + farmhousePizza.Cost());

            //farmhouse pizza with extra mushroom
            BasePizza farmHousePizzaWithExtraMushroom = new Mushroom(new FarmhousePIzza());
            Console.WriteLine("farm house pizza with extra mushroom " + farmHousePizzaWithExtraMushroom.Cost());

            //vegDelightPizza with double extra cheese 
            BasePizza vegDelightPizzaWithDoubleExtraCheese = new ExtraChees(new ExtraChees(new VegDelightPizza()));
            Console.WriteLine("VegDelight Pizza with extra cheese " + vegDelightPizzaWithDoubleExtraCheese.Cost());

            Console.ReadKey();
        }
    }
}
