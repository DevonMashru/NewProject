using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WakandaSportsClasses;

namespace Wakanda_Sports_Testing
{
    [TestClass]
    public class TstItemNo
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsItem AnItem = new clsItem();
            Assert.IsNotNull(AnItem);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsItem AnItem = new clsItem();
            string TestData = "Football Shirts";
            AnItem.Name = TestData;
            Assert.AreEqual(AnItem.Name, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsItem AnItem = new clsItem();
            DateTime TestData = DateTime.Now.Date;
            AnItem.DateAdded = TestData;
            Assert.AreEqual(AnItem.DateAdded, TestData);
        }

        [TestMethod]
        public void CategoryPropertyOK()
        {
            clsItem AnItem = new clsItem();
            string TestData = "Football Socks";
            AnItem.Category = TestData;
            Assert.AreEqual(AnItem.Category, TestData);
        }

        [TestMethod]
        public void BrandPropertyOK()
        {
            clsItem AnItem = new clsItem();
            string TestData = "Nike";
            AnItem.Brand = TestData;
            Assert.AreEqual(AnItem.Brand, TestData);
        }

        [TestMethod]
        public void SizePropertyOK()
        {
            clsItem AnItem = new clsItem();
            string TestData = "Large";
            AnItem.Size = TestData;
            Assert.AreEqual(AnItem.Size, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsItem AnItem = new clsItem();
            Int32 TestData = 13;
            AnItem.Price = TestData;
            Assert.AreEqual(AnItem.Price, TestData);
        }

        [TestMethod]
        public void SerialNumberPropertyOK()
        {
            clsItem AnItem = new clsItem();
            Int32 TestData = 1245;
            AnItem.SerialNumber = TestData;
            Assert.AreEqual(AnItem.SerialNumber, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsItem AnItem = new clsItem();
            Boolean TestData = true;
            AnItem.Active = TestData;
            Assert.AreEqual(AnItem.Active, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsItem AnItem = new clsItem();
            Boolean Found = false;
            Int32 ItemNo = 77;
            Found = ItemNo.Find(ItemNo);
            Assert.IsTrue(Found);
        }
    }
}