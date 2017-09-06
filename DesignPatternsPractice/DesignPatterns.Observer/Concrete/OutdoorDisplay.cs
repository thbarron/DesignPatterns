using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Observer.Abstract;

namespace DesignPatterns.Observer.Concrete
{
    public class OutdoorDisplay : IObserver
    {
        private float temperature;
        private float humidity;
        private float pressure;

        public float Temperature => temperature;
        public float Humidity => humidity;
        public float Pressure => pressure;


        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }
    }
}
