namespace webportalapp.Domain.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public int ProductId { get; set; }
        public int ProductCount { get; set; }
        public int ShippingAddress {  get; set; }
        public int ShippingType { get; set; }
        public int BillingAddress { get; set; }
        public int BillingInformation { get; set; }

    }
}
