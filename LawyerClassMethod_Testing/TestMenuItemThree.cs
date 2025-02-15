﻿using CustomListClass_Method;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListClassMethod_Testing
{
    [TestClass]
    public class TestMenuItemThree
    {
        [TestMethod]
        public void CheckIndex_AreEqual()//naming convbention 'method, underscore, expected result. whenever third item needed, add an extra underscore. nned to add areference.
        { //arrange
            CustomList<string> addToIndex = new CustomList<string>();//empty list

            //act in effect, going to test the function for expected result
            addToIndex.Add("X");
            addToIndex.Add("Y");
            addToIndex.Add("Z");
            //Assert

            Assert.AreEqual("X", addToIndex[0]);
        }
        [TestMethod]
        public void CheckIndex_IndexPositionAsAnticipated()//naming convention 'method, underscore, expected result. whenever third item needed, add an extra underscore. nned to add areference.
        { //arrange
            CustomList<string> addToIndex = new CustomList<string>();//empty list

            //act in effect, going to test the function for expected result
            addToIndex.Add("X");
            addToIndex.Add("Y");
            addToIndex.Add("Z");
            //Assert

            Assert.AreEqual("X", addToIndex[0]);
            Assert.AreEqual("Y", addToIndex[1]);
        }
    }
}
