using System;
using System.Collections.Generic;
using System.Text;

namespace RestauraceKasa.Models
{
    public class RestaurantTable
    {
        public int TableNumber { get; set; }
        public Order CurrentOrder { get; set; }
        public bool IsOccupied { get; set; }

        public RestaurantTable()
        {
            CurrentOrder = new Order(this.TableNumber);
        }

       


    }
}
