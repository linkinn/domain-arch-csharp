using NerdStore.Catalog.Application.ViewModels;

namespace NerdStore.Catalog.Application.Services
{
    public interface IProductAppService : IDisposable
    {
        Task<IEnumerable<ProductViewModel>> GetAllProducts();
        Task<ProductViewModel> GetProductById(Guid id);
        Task<IEnumerable<ProductViewModel>> GetProductsByCategory(int code);
        Task<IEnumerable<CategoryViewModel>> GetAllCategories();

        Task AddProduct(ProductViewModel productViewModel);
        Task UpdateProduct(ProductViewModel productViewModel);

        Task<ProductViewModel> DebitStock(Guid id, int quantity);
        Task<ProductViewModel> RestoreStock(Guid id, int quantity);
    }
}
