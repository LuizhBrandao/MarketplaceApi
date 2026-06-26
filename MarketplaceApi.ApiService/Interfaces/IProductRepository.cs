using MarketplaceApi.ApiService.Models;

namespace MarketplaceApi.ApiService.Interfaces;

public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    void Add(Product product);
    void Delete(Guid id);
}
