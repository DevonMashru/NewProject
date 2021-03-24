using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WakandaSportsClasses;

namespace Wakanda_Sports_Testing
{
    [TestClass]
    public class tstItem
    {
        string Name = "Mercurial Dream Superfly 8";
        string DateAdded = DateTime.Now.Date.ToString();
        string Category = "Football Boots";
        string Brand = "Nike";
        string Size = "UK 6 (EU 39)";
        Int32 Price = 85;
        Int32 SerialNumber = 1367;
               
        [TestMethod]
        public void InstanceOK()
        {
            clsItem AnItem = new clsItem();
            Assert.IsNotNull(AnItem);
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
        public void DateAddedPropertyOK()
        {
            clsItem AnItem = new clsItem();
            DateTime TestData = DateTime.Now.Date;
            AnItem.DateAdded = TestData;
            Assert.AreEqual(AnItem.DateAdded, TestData);
        }

        [TestMethod]
        public void ItemNoOK()
        {
            clsItem AnItem = new clsItem();
            Int32 TestData = 77;
            AnItem.ItemNo = TestData;
            Assert.AreEqual(AnItem.ItemNo, TestData);
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
        public void NamePropertyOK()
        {
            clsItem AnItem = new clsItem();
            string TestData = "Football Shirts";
            AnItem.Name = TestData;
            Assert.AreEqual(AnItem.Name, TestData);
        }
    
        [TestMethod]
        public void FindMethodOK()
        {
            clsItem AnItem = new clsItem();
            Boolean Found = false;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestItemNoFound()
        {
            clsItem AnItem = new clsItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemNo != 77)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsItem AnItem = new clsItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.Name != "Mercurial Dream Superfly 8")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsItem AnItem = new clsItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.DateAdded != Convert.ToDateTime("01/10/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCategoryFound()
        {
            clsItem AnItem = new clsItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.Category != "Football Boots")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBrandFound()
        {
            clsItem AnItem = new clsItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.Brand != "Nike")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSizeFound()
        {
            clsItem AnItem = new clsItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.Size != "UK 6 (EU 39)")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsItem AnItem = new clsItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.Price != 85)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSerialNumberFound()
        {
            clsItem AnItem = new clsItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.SerialNumber != 1367)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsItem AnItem = new clsItem();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    
        [TestMethod]
        public void ValidMethodOK()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }
    }
}