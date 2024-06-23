namespace webportalapp.API.Dtos.Product
{
    public class UpdateProductRequestDto
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public int ProductCount { get; set; }
        public int ProductPrice { get; set; }
    }
}
