using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Observer.Abstract;

namespace DesignPatterns.Observer.Concrete
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            var observerFound = observers.Contains(observer);
            
                
        }

        public void NotifyObservers()
        {
            throw new NotImplementedException();
        }
    }
}
