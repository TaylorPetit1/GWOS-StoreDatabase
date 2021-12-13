using System;

namespace EFDataAccessLibrary.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public int StockId { get; set; }
        public int Quantity { get; set; }
        public decimal GroupPrice { get; set; }
        public bool IsStock { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}