using BoutiqueManagement.IServices;
using BoutiqueManagement.Models;
using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoutiqueManagement.Services
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly IProductCatalog _productCatalog;
        private readonly ILogger<ShoppingCart> _logger;


        private readonly List<CartItem> _items = new List<CartItem>();


        public ShoppingCart(IProductCatalog productCatalog, ILogger<ShoppingCart> logger)
        {
            _productCatalog = productCatalog;
            _logger = logger;
        }


        public void AddToCart(Product product, int quantity)
        {
            var item = _items.FirstOrDefault(i => i.Product.ProductId == product.ProductId);


            if (item == null)
            {
                _items.Add(new CartItem { Product = product, Quantity = quantity });
            }
            else
            {
                item.Quantity += quantity;
            }


            _logger.LogInformation("{0} {1}(s) added to cart.", quantity, product.ProductName);
        }


        public void RemoveFromCart(Product product, int quantity)
        {
            var item = _items.FirstOrDefault(i => i.Product.ProductId == product.ProductId);


            if (item != null)
            {
                item.Quantity -= quantity;


                if (item.Quantity <= 0)
                {
                    _items.Remove(item);
                }


                _logger.LogInformation("{0} {1}(s) removed from cart.", quantity, product.ProductName);
            }
        }


        public decimal CalculateTotal()
        {
            decimal total = 0;


            foreach (var item in _items)
            {
                var product = _productCatalog.GetProduct(item.Product.ProductId);
                total += item.Quantity * product.Price;
            }


            return total;
        }
    }
}