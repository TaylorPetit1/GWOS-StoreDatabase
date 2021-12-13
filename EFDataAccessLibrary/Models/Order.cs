using System;
using System.Collections.Generic;

namespace EFDataAccessLibrary.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string OrderStatus { get; set; }
        public List<Stock> StockId { get; set; }
        public decimal OrderPrice { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}