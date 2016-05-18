namespace ReactSitecore.Models
{
    public class LineItemModel
    {
        public string ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public long Quantity { get; set; }
    }
}