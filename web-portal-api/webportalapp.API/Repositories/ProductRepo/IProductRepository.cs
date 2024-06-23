using webportalapp.API.Dtos.Product;
using webportalapp.Domain.Entities;

namespace webportalapp.API.Repositories.ProductRepo
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<Product> UpdateAsync(int id, UpdateProductRequestDto productDto);

        Task<Product?> CreateProduct(Product productModel);
        Task<Product?> DeleteAsync(int id);
    }
}
