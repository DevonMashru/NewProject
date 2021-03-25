using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WakandaSportsClasses;
using System.Collections.Generic;

namespace Wakanda_Sports_Testing
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Name = "Mercurial Dream Superfly 8";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Category = "Football Boots";
            TestItem.Brand = "Nike";
            TestItem.Size = "UK 6 (EU 39)";
            TestItem.Price = 85;
            TestItem.SerialNumber = 1367;
            TestItem.Active = true;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            TestItem.Name = "Mercurial Dream Superfly 8";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Category = "Football Boots";
            TestItem.Brand = "Nike";
            TestItem.Size = "UK 6 (EU 39)";
            TestItem.Price = 85;
            TestItem.SerialNumber = 1367;
            TestItem.Active = true;
            AllStocks.ThisStock = TestItem;
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Name = "Mercurial Dream Superfly 8";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Category = "Football Boots";
            TestItem.Brand = "Nike";
            TestItem.Size = "UK 6 (EU 39)";
            TestItem.Price = 85;
            TestItem.SerialNumber = 1367;
            TestItem.Active = true;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.Name = "Mercurial Dream Superfly 8";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Category = "Football Boots";
            TestItem.Brand = "Nike";
            TestItem.Size = "UK 6 (EU 39)";
            TestItem.Price = 85;
            TestItem.SerialNumber = 1367;
            TestItem.Active = true;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.ItemNo = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }
    }
}