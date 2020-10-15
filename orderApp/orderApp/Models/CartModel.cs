using System;
using System.Collections.Generic;
using System.Text;

namespace orderApp.Models
{
   public class CartModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}
