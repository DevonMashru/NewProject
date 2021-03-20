using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wakanda_Sports_Testing
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exist
            Assert.IsNotNull(AnStock);
        }
    }
}
