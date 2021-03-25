using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WakandaSportsClasses;

namespace Wakanda_Sports_Testing
{
    [TestClass]
    public class tstStock
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
            clsStock AnItem = new clsStock();
            Assert.IsNotNull(AnItem);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsStock AnItem = new clsStock();
            Boolean TestData = true;
            AnItem.Active = TestData;
            Assert.AreEqual(AnItem.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsStock AnItem = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AnItem.DateAdded = TestData;
            Assert.AreEqual(AnItem.DateAdded, TestData);
        }

        [TestMethod]
        public void ItemNoOK()
        {
            clsStock AnItem = new clsStock();
            Int32 TestData = 77;
            AnItem.ItemNo = TestData;
            Assert.AreEqual(AnItem.ItemNo, TestData);
        }

        [TestMethod]
        public void CategoryPropertyOK()
        {
            clsStock AnItem = new clsStock();
            string TestData = "Football Socks";
            AnItem.Category = TestData;
            Assert.AreEqual(AnItem.Category, TestData);
        }

        [TestMethod]
        public void BrandPropertyOK()
        {
            clsStock AnItem = new clsStock();
            string TestData = "Nike";
            AnItem.Brand = TestData;
            Assert.AreEqual(AnItem.Brand, TestData);
        }

        [TestMethod]
        public void SizePropertyOK()
        {
            clsStock AnItem = new clsStock();
            string TestData = "Large";
            AnItem.Size = TestData;
            Assert.AreEqual(AnItem.Size, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock AnItem = new clsStock();
            Int32 TestData = 13;
            AnItem.Price = TestData;
            Assert.AreEqual(AnItem.Price, TestData);
        }

        [TestMethod]
        public void SerialNumberPropertyOK()
        {
            clsStock AnItem = new clsStock();
            Int32 TestData = 1245;
            AnItem.SerialNumber = TestData;
            Assert.AreEqual(AnItem.SerialNumber, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsStock AnItem = new clsStock();
            string TestData = "Football Shirts";
            AnItem.Name = TestData;
            Assert.AreEqual(AnItem.Name, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void TestItemNoFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemNo != 77)
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.Name != "Mercurial Dream Superfly 8")
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.DateAdded != Convert.ToDateTime("01/10/2020"))
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestCategoryFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.Category != "Football Boots")
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestBrandFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.Brand != "Nike")
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestSizeFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.Size != "UK 6 (EU 39)")
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.Price != 85)
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestSerialNumberFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.SerialNumber != 1367)
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsStock AnItem = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 77;
            Found = AnItem.Find(ItemNo);
            if (AnItem.Active != true)
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Name = "aa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Name = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NamePlusOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Name = "aaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsStock AnItem = new clsStock();
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
            clsStock AnItem = new clsStock();
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
            clsStock AnItem = new clsStock();
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
            clsStock AnItem = new clsStock();
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
            clsStock AnItem = new clsStock();
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
            clsStock AnItem = new clsStock();
            String Error = "";
            string DateAdded = "this is not a date!";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMinLessOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Category = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMin()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Category = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMinPlusOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Category = "aa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxLessOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Category = "aaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMax()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Category = "aaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxPlusOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Category = "aaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMid()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Category = "aaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMinLessOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Brand = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMin()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Brand = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMinPlusOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Brand = "aa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxLessOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Brand = "aaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMax()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Brand = "aaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxPlusOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Brand = "aaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMid()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Brand = "aaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMinLessOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Size = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMin()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Size = "a";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMinPlusOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Size = "aa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxLessOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Size = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMax()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Size = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxPlusOne()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Size = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMid()
        {
            clsStock AnItem = new clsStock();
            String Error = "";
            string Size = "aaaaaaaaaaaaaaaa";
            Error = AnItem.Valid(Name, DateAdded, Category, Brand, Size, Price, SerialNumber);
            Assert.AreEqual(Error, "");
        }
    }
}