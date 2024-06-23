using webportalapp.API.Dtos.Purchase;
using webportalapp.Domain.Entities;

namespace webportalapp.API.Mappers
{
    public static class PurchaseMappers
    {
        public static PurchaseDto ToPurchaseDto(this Purchase purchaseModel)
        {
            return new PurchaseDto
            {
                Id = purchaseModel.Id,
                BuyerId = purchaseModel.BuyerId,
                ProductId = purchaseModel.ProductId,
                ProductCount = purchaseModel.ProductCount,
                ShippingAddress = purchaseModel.ShippingAddress,
                ShippingType = purchaseModel.ShippingType,
                BillingAddress = purchaseModel.BillingAddress,
            };
        }
    }
}
