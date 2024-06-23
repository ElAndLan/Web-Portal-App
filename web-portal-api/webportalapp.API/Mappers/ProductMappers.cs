using webportalapp.API.Dtos.Product;
using webportalapp.Domain.Entities;

namespace webportalapp.API.Mappers
{
    public static class ProductMappers
    {
        public static ProductDto ToProductDto(this Product productModel) {
            return new ProductDto {
                Id = productModel.Id,
                ProductName = productModel.ProductName,
                ProductDescription = productModel.ProductDescription,
                ProductCategory = productModel.ProductCategory,
                ProductPrice = productModel.ProductPrice,
                ProductCount = productModel.ProductCount
            }; 

        }
        public static Product ToProductFromCreateDto(this CreateProductRequestDto productDto)
        {

            return new Product
            {
                ProductName = productDto.ProductName,
                ProductDescription = productDto.ProductDescription,
                ProductCategory = productDto.ProductCategory,
                ProductPrice = productDto.ProductPrice,
                ProductCount = productDto.ProductCount
            };
        }
    }
}
