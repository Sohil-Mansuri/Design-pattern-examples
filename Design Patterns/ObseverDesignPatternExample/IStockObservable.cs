using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObseverDesignPatternExample
{
    internal interface IStockObservable
    {
        void Add(INotificationObserver observer);

        void Remove(INotificationObserver observer);

        void Notify();

        void SetStock(int newStock);

        int getStock();
    }
}
