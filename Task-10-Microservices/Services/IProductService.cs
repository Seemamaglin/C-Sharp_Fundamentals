using Task_10_Microservices.Models;
namespace Task_10_Microservices.Services;
public interface IProductService
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product> GetByIdAsync(int id);
    Task<Product> AddAsync(Product product);
}