using System;

namespace EFDataAccessLibrary.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public string StockName { get; set; }
        public decimal StockPrice { get; set; }
        public int CurrentStock { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}