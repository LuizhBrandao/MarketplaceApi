using MarketplaceApi.ApiService.Interfaces;
using MarketplaceApi.ApiService.Models;

namespace MarketplaceApi.ApiService.Repositories;

public class ProductRepository : IProductRepository
{
    // Utilizamos uma lista privada em memória para simular o banco de dados
    private readonly List<Product> _products = new();

    public IEnumerable<Product> GetAll()
    {
        return _products;
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Delete(Guid id)
    {
        // Remove todos os produtos que tenham o Id correspondente (neste caso, será apenas um)
        _products.RemoveAll(p => p.Id == id);
    }
}