﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}