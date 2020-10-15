using orderApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace orderApp.View_Models
{
    class CartViewModel
    {
        public ObservableCollection<CartModel> CartItems { get; set; } = new ObservableCollection<CartModel>();
        public CartViewModel()
        {
            CartItems.Add(new CartModel
            {
                Image= "Shirt1.jpg",
                Name="Outfiter",
                Type="Colthes",
                Price="2300.00",
                Quantity=1
                

            });
            CartItems.Add(new CartModel
            {
                Image = "Shoes1.png",
                Name = "Service Shoes",
                Type = "Shoes",
                Price = "2300.00",
                Quantity = 1


            });
            CartItems.Add(new CartModel
            {
                Image = "Mobile.jpg",
                Name = "Tecno",
                Type = "Device",
                Price = "2300.00",
                Quantity = 1


            });
        }
    }
}
