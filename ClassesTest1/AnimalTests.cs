using System;
using System.Collections.Generic;
using System.Diagnostics;
using ClassesTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesTest1
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void DogAgeName()
        {
            Dog dog = new Dog("Kuba", 2);
             
            Assert.AreEqual("Kuba", dog.Name);
            Assert.AreEqual(2, dog.Age);
        }

        [TestMethod]
        public void DogFreeDefaultValueShouldBeTrue()
        {
            Dog dog = new Dog("Kuba", 2);
            Assert.IsTrue(dog.IsFree);

        }

        [TestMethod]
        public void DogPutToCellShouldBeFalse()
        {
            Dog dog = new Dog("Kuba", 2);

            dog.PutToCell();

            Assert.IsFalse(dog.IsFree);

        }


        [TestMethod]
        public void DogAfterFreedShouldBeTrue()
        {
            Dog dog = new Dog("Kuba", 2);

            dog.PutToCell();
            dog.FreeAnimal();

            Assert.IsTrue(dog.IsFree);

        }

        [TestMethod]
        public void DogShouldBark()
        {
            Animal dog = new Dog("Kuba", 2);

            string dogSound = dog.SpreadSound();
            Assert.AreEqual("woof woof", dogSound);
        }

        [TestMethod]
        public void ListOfAnimals()
        {
            List<Animal> listOfAnimals = new List<Animal>();

            listOfAnimals.Add(new Dog("Misza", 2));
            listOfAnimals.Add(new Dog("Bob", 3));
            listOfAnimals.Add(new Horse("Nene", 4));
            listOfAnimals.Add(new Lizard("Fabio", 6));

            foreach (var animal in listOfAnimals)
            {
                Debug.WriteLine(animal.Name);
            }
        }

        [TestMethod]
        public void AnimalSpreadSound()
        {
            List<Animal> listOfAnimals = new List<Animal>();

            listOfAnimals.Add(new Dog("Misza", 2));
            listOfAnimals.Add(new Dog("Bob", 3));
            listOfAnimals.Add(new Horse("Nene", 4));
            listOfAnimals.Add(new Lizard("Fabio", 6));

            foreach (var animal in listOfAnimals)
            {
                Debug.WriteLine(animal.SpreadSound());
            }
        }
    }
}
