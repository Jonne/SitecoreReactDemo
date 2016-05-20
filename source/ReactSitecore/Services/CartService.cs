using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

using ReactSitecore.Models;

namespace ReactSitecore.Services
{
    public class CartService
    {
        private const string CartSessionKey = "Cart";

        private CartModel Current
        {
            get
            {
                HttpSessionState session = HttpContext.Current.Session;

                if (session[CartSessionKey] == null)
                {
                    session[CartSessionKey] = CreateDummyCart();
                }

                return (CartModel)session[CartSessionKey];
            }
        }

        private CartModel CreateDummyCart()
        {
            return new CartModel
            {
                LineItems = new List<LineItemModel>
                {
                    new LineItemModel
                    {
                        ProductId = "001",
                        Description = "Cheese scraper",
                        Price = 2.99m,
                        Quantity = 1
                    },
                    new LineItemModel
                    {
                        ProductId = "002",
                        Description = "Wine opener",
                        Price = 6.00m,
                        Quantity = 1
                    },
                    new LineItemModel
                    {
                        ProductId = "003",
                        Description = "Citrus peeler",
                        Price = 1.45m,
                        Quantity = 1
                    }
                }
            };
        }

        public CartModel Get()
        {
            RecalculateCosts();

            return Current;
        }

        private void RecalculateCosts()
        {
            Current.Subtotal = Current.LineItems.Sum(x => x.Price * x.Quantity);
        }

        public void Remove(string productId)
        {
            LineItemModel lineItem = Current.LineItems.Single(x => x.ProductId == productId);

            Current.LineItems.Remove(lineItem);
        }
    }
}
