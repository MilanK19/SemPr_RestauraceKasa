using System;
using System.Collections.Generic;
using System.Text;

namespace RestauraceKasa.Models
{
    public class ArchivedOrder
    {

        public int TableNumber { get; set; }
        public List<Product> Items { get; set; } = new List<Product>();
        public DateTime PaymentTime { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public decimal TotalPrice { get; set; }

        public ArchivedOrder()
        {

        }

    }
}
