using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsharpUnitTestAsignment1;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpUnitTestAsignment1.Tests
{
    [TestClass()]
    public class BicycleTests
    {
        private Bicycle _bicycle;

        [TestMethod]
        public void TestConstructor()
        {
            Bicycle b1 = new Bicycle();
            Bicycle b2 = new Bicycle("G", 11.99d, 4, 14);

            Assert.AreNotEqual(null, b1);
            Assert.AreNotEqual(null, b2);
        }

        [TestInitialize]
        public void Init()
        {
            _bicycle = new Bicycle();
        }

        [TestMethod]
        public void PriceTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bicycle.Price = -1);

            _bicycle.Price = 0;

            Assert.AreEqual(0d, _bicycle.Price);
        }

        [TestMethod]
        public void ColorTest()
        {
            Assert.ThrowsException<ArgumentNullException>(() => _bicycle.Color = null);

            Assert.ThrowsException<ArgumentException>(() => _bicycle.Color = "");

            _bicycle.Color = "G";

            Assert.AreEqual("G", _bicycle.Color);
        }

        [TestMethod]
        public void GearTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bicycle.Gear = 2);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bicycle.Gear = 33);

            _bicycle.Gear = 3;
            
            Assert.AreEqual(3, _bicycle.Gear);
        }

        [TestMethod]
        public void TestToString()
        {
            Assert.AreEqual("Id: 0, Color: Not applied, Price: 0, Gears: 3", _bicycle.ToString());
        }
    }
}