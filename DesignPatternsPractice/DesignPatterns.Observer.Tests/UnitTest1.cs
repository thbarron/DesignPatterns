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
    }
}
