namespace Cars.Tests.Moq
{
    using System;
    using System.Collections.Generic;

    using Cars.Contracts;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Cars.Controllers;
    using Cars.Models;

    using global::Moq;

    [TestClass]
    public class CarsControllerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectExceptionWhenDetailsMethodIsCalledWithNonExistingCarId()
        {
            var mockCarsRepository = new Mock<ICarsRepository>();
            mockCarsRepository.Setup(cr => cr.GetById(It.IsAny<int>())).Returns(() => null);
            var carsController = new CarsController(mockCarsRepository.Object);
            carsController.Details(1);
        }

        [TestMethod]
        public void ExpectCarsRepositorySearchMethodReturnsCorrectResult()
        {
            var mockCarsCollection = new Mock<ICollection<Car>>();
            var mockCarsRepository = new Mock<ICarsRepository>();
            mockCarsRepository.Setup(cr => cr.Search(It.IsAny<string>())).Returns(mockCarsCollection.Object);
            var carsController = new CarsController(mockCarsRepository.Object);
            var result = carsController.Search(It.IsAny<string>());
            Assert.IsTrue(result.Model.Equals(mockCarsCollection.Object));
        }

        [TestMethod]
        public void ExpectCarsRepositoryToSortByMake()
        {
            var mockCarsCollection = new Mock<ICollection<Car>>();
            var mockCarsRepository = new Mock<ICarsRepository>();
            mockCarsRepository.Setup(cr => cr.SortedByMake()).Returns(mockCarsCollection.Object);
            var carsController = new CarsController(mockCarsRepository.Object);
            var result = carsController.Sort("make");
            Assert.IsTrue(result.Model.Equals(mockCarsCollection.Object));
        }

        [TestMethod]
        public void ExpectCarsRepositoryToSortByYear()
        {
            var mockCarsCollection = new Mock<ICollection<Car>>();
            var mockCarsRepository = new Mock<ICarsRepository>();
            mockCarsRepository.Setup(cr => cr.SortedByYear()).Returns(mockCarsCollection.Object);
            var carsController = new CarsController(mockCarsRepository.Object);
            var result = carsController.Sort("year");
            Assert.IsTrue(result.Model.Equals(mockCarsCollection.Object));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectCarsRepositoryToThrowArgumentExceptionWhenSearchingWithInvalidString()
        {
            var mockCarsRepository = new Mock<ICarsRepository>();
            var carsController = new CarsController(mockCarsRepository.Object);
            carsController.Sort(string.Empty);
        }

        [TestMethod]
        public void ExpectCarsControllerEmptyConstructorToCreateInstance()
        {
            var carsController = new CarsController();
            Assert.IsNotNull(carsController);
        }
    }
}
