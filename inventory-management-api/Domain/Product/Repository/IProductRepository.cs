using Domain.Product.Entity;

namespace Domain.Product.Repository;

public interface IProductRepository{
    Task<List<Product>> GetAll();
    Task<Product?> GetById(int id);
}