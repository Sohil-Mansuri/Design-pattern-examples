using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObseverDesignPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationObserver observer1 = new EmailObserver("sohil");
            INotificationObserver observer2 = new EmailObserver("test");
            INotificationObserver observer3 = new MobileObserver("Jishan");

            IPhoneObservable iphoneObserver = new IPhoneObservable();

            iphoneObserver.Add(observer1);
            iphoneObserver.Add(observer2);
            iphoneObserver.Add(observer3);

            iphoneObserver.SetStock(20);
            iphoneObserver.SetStock(10);
            iphoneObserver.ResetStock();
            iphoneObserver.SetStock(12);


            Console.ReadKey();
            
        }
    }
}
