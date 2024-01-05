namespace NerdStore.Catalog.Domain
{
    public interface IStockService : IDisposable
    {
        Task<bool> DebitStock(Guid productId, int quantity);
        Task<bool> RestoreStock(Guid productId, int quantity);
    }
}
