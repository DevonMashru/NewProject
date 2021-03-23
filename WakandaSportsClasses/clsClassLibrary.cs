using System;

namespace WakandaSportsClasses
{
    public class clsItem
    {
        public clsItem()
        {
        }
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public int SerialNumber { get; set; }
        public Int32 ItemNo { get; set; }
        public string Name { get; set; }
    }
}