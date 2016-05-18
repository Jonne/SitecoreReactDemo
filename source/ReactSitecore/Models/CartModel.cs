using System.Collections.Generic;

namespace ReactSitecore.Models
{
    public class CartModel
    {
        public List<LineItemModel> LineItems { get; set; }

        public decimal Subtotal { get; set; }
    }
}