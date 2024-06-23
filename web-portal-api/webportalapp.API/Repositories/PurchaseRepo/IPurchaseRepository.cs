using webportalapp.Domain.Entities;

namespace webportalapp.API.Repositories.PurchaseRepo
{
    public interface IPurchaseRepository
    {
        Task<List<Purchase>> GetAllAsync();
    }
}
