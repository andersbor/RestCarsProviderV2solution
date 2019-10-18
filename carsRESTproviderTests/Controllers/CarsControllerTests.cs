using Microsoft.VisualStudio.TestTools.UnitTesting;
using carsRESTprovider.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using carsRESTprovider.model;

namespace carsRESTprovider.Controllers.Tests
{
    [TestClass()]
    public class CarsControllerTests
    {
        private CarsController controller;

        [TestInitialize]
        public void Init()
        {
            controller = new CarsController();
        }

        [TestMethod()]
        public void GetTest()
        {
   
            IEnumerable<Car> cars = controller.GetAll();

            Assert.AreEqual(3, cars.count);

        }

        [TestMethod()]
        public void GetByIdTest()
        {
            var car = controller.GetById(1);

        }

        [TestMethod()]
        public void GetByVendorTest()
        {
            //var cars = 
            Assert.Fail();
        }

        [TestMethod()]
        public void GetBymodelTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByPriceRangeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PutTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }
    }
}