using MarketplaceApi.ApiService.Interfaces;
using MarketplaceApi.ApiService.Models;

namespace MarketplaceApi.ApiService.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    // Injeção de Dependência: O serviço pede um repositório para funcionar
    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Product> GetAll()
    {
        return _repository.GetAll();
    }

    public Product Add(Product product)
    {
        // Aqui entrariam as validações de negócio.
        // Exemplo: Garantimos que o produto receba um novo ID (já que estamos a usar records)
        var newProduct = product with { Id = Guid.NewGuid() };

        _repository.Add(newProduct);
        return newProduct;
    }

    public bool Delete(Guid id)
    {
        // Aqui poderíamos validar se o produto existe antes de tentar deletar
        _repository.Delete(id);
        return true;
    }
}