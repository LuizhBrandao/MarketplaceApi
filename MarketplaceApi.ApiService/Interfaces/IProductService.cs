using MarketplaceApi.ApiService.Models;

namespace MarketplaceApi.ApiService.Interfaces;

public interface IProductService
{
    IEnumerable<Product> GetAll();
    Product Add(Product product);
    bool Delete(Guid id);
}
