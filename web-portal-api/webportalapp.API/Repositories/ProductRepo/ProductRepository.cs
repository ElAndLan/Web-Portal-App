using Microsoft.EntityFrameworkCore;
using webportalapp.API.Dtos.Product;
using webportalapp.Domain.Entities;
using webportalapp.Infrastructure.Persistence.PostgreSQL;

namespace webportalapp.API.Repositories.ProductRepo
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppSQLContext _context;
        public ProductRepository(AppSQLContext context)
        {
            _context = context;
        }

        public async Task<Product?> CreateProduct(Product productModel)
        {
            await _context.Products.AddAsync(productModel);
            await _context.SaveChangesAsync();
            return productModel;
        }

        public async Task<Product?> DeleteAsync(int id)
        {
            var productModel = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (productModel == null) {
                return null;
            }

            _context.Products.Remove(productModel);
            await _context.SaveChangesAsync();

            return productModel;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> UpdateAsync(int id, UpdateProductRequestDto productDto)
        {
            var existingProduct = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (existingProduct == null)
            {
                return null;
            }

            existingProduct.ProductName = productDto.ProductName;
            existingProduct.ProductDescription = productDto.ProductDescription;
            existingProduct.ProductCategory = productDto.ProductCategory;
            existingProduct.ProductPrice = productDto.ProductPrice;
            existingProduct.ProductCount = productDto.ProductCount;

            await _context.SaveChangesAsync();
            return existingProduct;

        }
    }
}
