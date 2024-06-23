using Microsoft.EntityFrameworkCore;
using webportalapp.Domain.Entities;
using webportalapp.Infrastructure.Persistence.PostgreSQL;

namespace webportalapp.API.Repositories.PurchaseRepo
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly AppSQLContext _context;
        public PurchaseRepository(AppSQLContext context)
        {
            _context = context;
        }

        public Task<List<Purchase>> GetAllAsync()
        {
            return _context.Purchases.ToListAsync();
        }
    }
}
