﻿namespace Basket.API.Entities
{
    public class ShoppingCartItem
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Color  { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductId { get; set; }
    }
}
