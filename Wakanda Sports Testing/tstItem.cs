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

        [TestMethod]
        public void NameMin()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Name = "aa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Name = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NamePlusOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Name = "aaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string DateAdded = "this is not a date!";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMinLessOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Category = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMin()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Category = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMinPlusOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Category = "aa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxLessOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Category = "aaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMax()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Category = "aaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxPlusOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Category = "aaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMid()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Category = "aaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMinLessOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Brand = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMin()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Brand = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMinPlusOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Brand = "aa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxLessOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Brand = "aaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMax()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Brand = "aaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxPlusOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Brand = "aaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMid()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Brand = "aaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMinLessOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Size = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMin()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Size = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMinPlusOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Size = "aa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxLessOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Size = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMax()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Size = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxPlusOne()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Size = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMid()
        {
            clsItem AnItem = new clsItem();
            String Error = "";
            string Size = "aaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }
    }
}                                  