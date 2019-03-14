using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListProjectTest
{
    [TestClass]
    public class CustomListProjectTest
    {
        [TestMethod]
        public void Add_AddToEmptyList_AddsItemToIndexZero()
        {
            // Arrange
            CustomList<int> test = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // Act
            test.Add(itemToAdd);
            actual = test[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_EmptyList_CountIncrements()
        {
            // Arrange
            CustomList<int> test = new CustomList<int>();
           int itemToAdd = 10;
           int expected = 1;
           int actual;

            // Act
            test.Add(itemToAdd);
            actual = test.Count;

           // Assert
           Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ListCountThree_AddsToIndexThree()
        {
            // Arrange
            CustomList<int> test = new CustomList<int>();
            int itemToAdd = 10;
            test.Add(itemToAdd);
            test.Add(itemToAdd);
            test.Add(itemToAdd);
            int expected = 10;
            int actual;

            // Act
            test.Add(itemToAdd);
            actual = test[3];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ListCountOne_AddsToIndexThree()
        {
            // Arrange
            CustomList<int> test = new CustomList<int>();
            int itemToAdd = 10;
            test.Add(itemToAdd);
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
            CustomList<int> test = new CustomList<int>();
            int itemToAdd = 10;
            test.Add(itemToAdd);
            test.Add(itemToAdd);
            test.Add(itemToAdd);
            test.Add(itemToAdd);
            int expected = 10;
            int actual;

            // Act
            test.Add(itemToAdd);
            actual = test[4];

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
