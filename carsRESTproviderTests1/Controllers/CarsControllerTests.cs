using Microsoft.VisualStudio.TestTools.UnitTesting;
using carsRESTprovider.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        public void GetAllTest()
        {
            IEnumerable<model.Car> cars = controller.GetAll();
            Assert.AreEqual(3, cars.Count());
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByVendorTest()
        {
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