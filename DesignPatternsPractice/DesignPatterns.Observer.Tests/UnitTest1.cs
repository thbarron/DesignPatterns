using System;
using DesignPatterns.Observer;
using DesignPatterns.Observer.Abstract;
using DesignPatterns.Observer.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DesignPatterns.Observer.Tests
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void CanAddObserverToSubject()
        {
            //Setup
            var mockSubject = new Mock<WeatherData>();
            var mockObserver = new Mock<OutdoorDisplay>();

            //Act
            mockSubject.Object.RegisterObserver(mockObserver.Object);

            //Assert
            Assert.AreEqual(1, mockSubject.Object.Observers.Count);

        }
        [TestMethod]
        public void CanRemoveObserverFromSubject()
        {
            //Setup
            var mockSubject = new Mock<WeatherData>();
            var mockObserver = new Mock<OutdoorDisplay>();

            //Act
            mockSubject.Object.RegisterObserver(mockObserver.Object);
            mockSubject.Object.RemoveObserver(mockObserver.Object);

            //Assert
            Assert.AreEqual(0, mockSubject.Object.Observers.Count);
        }

        [TestMethod]
        public void UpdatesReachObserver()
        {
            //Arrange
            var mockSubject = new Mock<WeatherData>();
            var mockObserver = new Mock<OutdoorDisplay>();

            //Act
            mockSubject.Object.RegisterObserver(mockObserver.Object);
            mockSubject.Object.SetMeasurements(72.5f, 35.7f, 1050.5f);

            //Assert
            Assert.AreEqual(mockSubject.Object.CurrentTemperature, mockObserver.Object.Temperature);
            Assert.AreEqual(mockSubject.Object.Humidity, mockObserver.Object.Humidity);
            Assert.AreEqual(mockSubject.Object.Pressure, mockObserver.Object.Pressure);
        }

        [TestMethod]
        public void UpdateChangesValuesInObserverWhenValuesExisted()
        {
            //Arrange
            var mockSubject = new Mock<WeatherData>();
            var mockObserver = new Mock<OutdoorDisplay>();
            mockSubject.Object.RegisterObserver(mockObserver.Object);
            mockSubject.Object.SetMeasurements(72.5f, 35.7f, 1050.5f);

            //Act
            mockSubject.Object.SetMeasurements(72.3f, 35.2f, 1050.5f);

            //Assert
            Assert.AreEqual(mockSubject.Object.CurrentTemperature, mockObserver.Object.Temperature);
            Assert.AreEqual(mockSubject.Object.Humidity, mockObserver.Object.Humidity);
            Assert.AreEqual(mockSubject.Object.Pressure, mockObserver.Object.Pressure);
        }
    }
}
