namespace InvokeApp.Shared.DTOs.Products
{
    public class ProductDetailDto
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool Sold { get; set; }
        public int SellerId { get; set; }
        public string SellerName {  get; set; }
        public string SellerImageUrl {  get; set; }
    }
}
