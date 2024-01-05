using NerdStore.Core.Data;

namespace NerdStore.Catalog.Domain
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(Guid id);
        Task<IEnumerable<Product>> GetProductByCategory(int code);
        Task<IEnumerable<Category>> GetAllCategories();

        void Add(Product product);
        void Update(Product product);

        void Add(Category category);
        void Update(Category category);
    }
}
