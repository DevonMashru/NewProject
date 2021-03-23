using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wakanda_Sports_Testing
{
    [TestClass]
    public class ItemNoTest
    {
        //create an instance of the new class we want to create
        clsName AnName = new clsName();
        //create some test data to assign to the Name
        Boolean TestData = true;
        //assign the data to the property
        AnName.Active = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnName.Active, TestData);
    }
}