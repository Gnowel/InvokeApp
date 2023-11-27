namespace InvokeApp.Shared.DTOs.Products
{
    public class ProductSellingDto
    {
        public Guid Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Sold { get; set; }


    }
}
