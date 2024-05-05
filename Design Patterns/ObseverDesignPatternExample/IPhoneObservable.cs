using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObseverDesignPatternExample
{
    internal class IPhoneObservable : IStockObservable
    {
        List<INotificationObserver> _observers = new List<INotificationObserver>();
        int _stock = 0;

        public void Add(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        public int getStock()
        {
           return _stock;
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public void Remove(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }

        public void SetStock(int newStock)
        {
           if(_stock == 0)
                Notify();

            _stock += newStock;
        }

        public void ResetStock()
        {
            _stock = 0;
        }
    }
}
