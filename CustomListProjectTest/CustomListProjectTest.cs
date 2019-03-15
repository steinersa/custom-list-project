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
        public void Add_ListCountFour_AddsToIndexFour()
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

        [TestMethod]
        public void Remove_ObjectAtIndexZeroRemoved_ObjectAtIndexOneShiftsToIndexZero()
        {
            // Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(10);
            test.Add(20);
            test.Add(30);
            test.Add(40);
            int expected = 20;
            int actual;

            // Act
            test.Remove(10);
            actual = test[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void Remove_ThingNotInList_ReturnsFalse()
        //{
        //    // Arrange
        //    CustomList<int> test = new CustomList<int>();
        //    test.Add(10);
        //    test.Add(20);
        //    test.Add(30);
        //    int itemToRemove = 40;
        //    bool expected = false;
        //    bool actual;

        //    // Act
        //    actual = test.Remove(itemToRemove);

        //    // Assert
        //    Assert.AreEqual(expected, actual);

        //}

        [TestMethod]
        public void Remove_ListCountFour_CountDecrements()
        {
            // Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(10);
            test.Add(20);
            test.Add(30);
            test.Add(40);
            int expected = 3;
            int actual;

            // Act
            test.Remove(40);
            actual = test.Count;

            // Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
