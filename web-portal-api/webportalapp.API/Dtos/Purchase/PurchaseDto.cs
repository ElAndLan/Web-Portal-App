namespace webportalapp.API.Dtos.Purchase
{
    public class PurchaseDto
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }

        public int ProductId { get; set; }
        public int ProductCount { get; set; }
        public int ShippingAddress { get; set; }
        public int ShippingType { get; set; }
        public int BillingAddress { get; set; }
    }
}
