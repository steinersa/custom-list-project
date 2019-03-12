using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProjectTest;
using System.Collections.Generic;

namespace CustomListProjectTest
{
    [TestClass]
    public class CustomListProjectTest
    {
        [TestMethod]
        public void Add_AddToEmptyList_AddsItemToIndexZero()
        {
            // Arrange
            List<int> test = new List<int>();
            int thingToAdd = 10;
            int expected = 10;
            int actual;

            // Act
            test.Add(thingToAdd);
            actual = test[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_EmptyList_CountIncrements()
        {
           // Arrange
           List<int> test = new List<int>();
           int thingToAdd = 10;
           int expected = 1;
           int actual;

           // Act
           actual = test.Count;

           // Assert
           Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ListCountThree_AddsToIndexThree()
        {
            // Arrange
            List<int> test = new List<int>();
            int thingToAdd = 10;
            test.Add(thingToAdd);
            test.Add(thingToAdd);
            test.Add(thingToAdd);
            int expected = 10;
            int actual;

            // Act
            test.Add(thingToAdd);
            actual = test[3];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ListCountOne_AddsToIndexThree()
        {
            // Arrange
            List<int> test = new List<int>();
            int thingToAdd = 10;
            test.Add(thingToAdd);
            int expected = 40;
            int actual;

            // Act
            test.Add(20);
            test.Add(30);
            test.Add(40);
            actual = test[3];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ListCountFour_AddsToIndexFour() // Array is full... need to make a new one
        {
            // Arrange
            List<int> test = new List<int>();
            int thingToAdd = 10;
            test.Add(thingToAdd);
            test.Add(thingToAdd);
            test.Add(thingToAdd);
            test.Add(thingToAdd);
            int expected = 10;
            int actual;

            // Act
            test.Add(thingToAdd);
            actual = test[4];

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
