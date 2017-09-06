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

        private readonly ArrayList _observers;
        public float CurrentTemperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public ArrayList Observers => _observers;

        public WeatherData()
        {
            _observers = new ArrayList();
        }
        
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(CurrentTemperature, Humidity, Pressure);
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
