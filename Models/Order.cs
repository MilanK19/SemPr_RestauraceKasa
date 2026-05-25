using System;
using System.Collections.Generic;
using System.Text;

namespace RestauraceKasa.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public List<Product> Items { get; set; } = new List<Product>();
        public DateTime CreatedAt { get; set; }
        public bool isPaid { get; set; }

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (var item in Items)
                {
                    total += item.Price;
                }
                return total;
            }
        }

        public Order(int tableNumber)
        {
            this.TableNumber = tableNumber;
        }

        public Order() { }


    }

   
}
