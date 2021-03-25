using System;
using System.Collections.Generic;

namespace WakandaSportsClasses
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("Name", mThisStock.Name);
            DB.AddParameter("DateAdded", mThisStock.DateAdded);
            DB.AddParameter("Category", mThisStock.Category);
            DB.AddParameter("Brand", mThisStock.Brand);
            DB.AddParameter("Size", mThisStock.Size);
            DB.AddParameter("Active", mThisStock.Active);
            return DB.Execute("sproc_tblStockFootballBoots_Insert");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemNo", mThisStock.ItemNo);
            DB.Execute("sproc_tblStockFootballBoots_Delete");
        }
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
        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStockFootballBoots_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStock.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStock.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                AnStock.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);
                AnStock.Size = Convert.ToString(DB.DataTable.Rows[Index]["Size"]);
                AnStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnStock.SerialNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["SerialNumber"]);
                mStockList.Add(AnStock);
                Index++;
            }
        }
    }
}