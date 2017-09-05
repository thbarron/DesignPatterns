using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Observer.Abstract;

namespace DesignPatterns.Observer.Concrete
{
    public class WeatherData : ISubject
    {

        private ArrayList observers;
        public float CurrentTemperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public ArrayList Observers => observers;

        public WeatherData()
        {
            observers = new ArrayList();
        }
        
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            var observerFound = observers.IndexOf(observer);
            if (observerFound != 0)
                observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            CurrentTemperature = temp;
            Humidity = humidity;
            Pressure = pressure;

            NotifyObservers();
        }
    }
}
