using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RestauraceKasa.Models
{
    public class RestaurantTable
    {
        public int TableNumber { get; set; }
        public Order CurrentOrder { get; set; } = new Order();
        
        [JsonIgnore]
        public bool IsOccupied => CurrentOrder?.Items?.Count > 0;

        public RestaurantTable()
        {

        }

        public RestaurantTable(int tableNumber)
        {
            TableNumber = tableNumber;

            CurrentOrder = new Order(tableNumber);
        }

       


    }
}
