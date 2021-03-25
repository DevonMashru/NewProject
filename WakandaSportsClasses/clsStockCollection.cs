using System.Collections.Generic;

namespace WakandaSportsClasses
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock { get; set; }
    }
}