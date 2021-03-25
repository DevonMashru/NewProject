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
            TestItem.ItemNo = 77;
            TestItem.Name = "Mercurial Dream Superfly 8";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Category = "Football Boots";
            TestItem.Brand = "Nike";
            TestItem.Size = "UK 6 (EU 39)";
            TestItem.Price = 85;
            TestItem.SerialNumber = 1367;
            TestItem.Active = true;
        }
    }
}
