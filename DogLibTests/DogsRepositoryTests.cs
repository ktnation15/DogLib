using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogLib.Tests
{
    [TestClass()]
    public class DogsRepositoryTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            //Arrange
            int expectedCount = 3;
            DogsRepository dogsRepository = new DogsRepository();
            //Act
            IEnumerable<Dog> dogs = dogsRepository.GetAll();
            //Assert
            Assert.AreEqual(expectedCount, dogs.Count());
        }
        [TestMethod()]
        public void GetByIdTest()
        {
            //Arrange
            int IdToFind = 2;
            DogsRepository dogsRepository = new DogsRepository();
            //Act
            Dog? dog = dogsRepository.GetById(IdToFind);
            //Assert
            Assert.AreEqual(IdToFind, dog?.Id);
        }

        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            DogsRepository dogsRepository = new DogsRepository();
            Dog dog = new Dog { Name = "Rover", Age = 4 };
            //Act
            Dog? addedDog = dogsRepository.Add(dog);
            //Assert
            Assert.AreEqual(dog, addedDog);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            //Arrange
            DogsRepository dogsRepository = new DogsRepository();
            int IdToDelete = 2;
            //Act
            Dog? deletedDog = dogsRepository.Delete(IdToDelete);
            //Assert
            Assert.AreEqual(IdToDelete, deletedDog?.Id);
        }
    }
}