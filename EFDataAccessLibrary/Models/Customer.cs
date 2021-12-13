using System;
using System.Collections.Generic;

namespace EFDataAccessLibrary.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<Order> PastOrders { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}