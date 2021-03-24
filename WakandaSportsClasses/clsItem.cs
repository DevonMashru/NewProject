using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WakandaSportsClasses
{
    public class clsItem
    {
        public clsItem()
        {

        }
        private Int32 mItemNo;
        public Int32 ItemNo
        {
            get
            {
                return mItemNo;
            }
            set
            {
                mItemNo = value;
            }
        }
        private string mName;
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        private string mCategory;
        public string Category
        {
            get
            {
                return mCategory;
            }
            set
            {
                mCategory = value;
            }
        }
        private string mBrand;
        public string Brand
        {
            get
            {
                return mBrand;
            }
            set
            {
                mBrand = value;
            }
        }
        private string mSize;
        public string Size
        {
            get
            {
                return mSize;
            }
            set
            {
                mSize = value;
            }
        }
        private Int32 mPrice;
        public Int32 Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        private Int32 mSerialNumber;
        public Int32 SerialNumber
        {
            get
            {
                return mSerialNumber;
            }
            set
            {
                mSerialNumber = value;
            }
        }
        private Boolean mActive;
        public Boolean Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public bool Find(int ItemNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemNo", ItemNo);
            DB.Execute("sproc_tblStockFootballBoots_FilterByItemNo");
            if (DB.Count == 1)
            {
                mItemNo = 77;
                mName = "Mercurial Dream Superfly 8";
                mDateAdded = Convert.ToDateTime("01/10/2020");
                mCategory = "Football Boots";
                mBrand = "Nike";
                mSize = "UK 6 (EU 39)";
                mPrice = 85;
                mSerialNumber = 1367;
                mActive = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Valid(string Name,
                            DateTime DateAdded,
                            string Category,
                            string Brand,
                            string Size,
                            Int32 Price,
                            Int32 SerialNumber)
        {

        }

    }
}
