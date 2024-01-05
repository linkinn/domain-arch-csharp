using NerdStore.Catalog.Domain.Events;
using NerdStore.Core.Bus;

namespace NerdStore.Catalog.Domain
{
    public class StockService : IStockService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediatrHandler _bus;

        public StockService(IProductRepository productRepository, IMediatrHandler bus)
        {
            _productRepository = productRepository;
            _bus = bus;
        }

        public async Task<bool> DebitStock(Guid productId, int quantity)
        {
            var product = await _productRepository.GetById(productId);

            if (product == null) return false;

            if (!product.ExistStock(quantity)) return false;

            product.DebitStock(quantity);

            if (product.StockQuantity < 10)
            {
                await _bus.PublishEvent(new ProductLowStockEvent(product.Id, product.StockQuantity));
            }

            _productRepository.Update(product);
            return await _productRepository.UnitOfWork.Commit();
        }

        public async Task<bool> RestoreStock(Guid productId, int quantity)
        {
            var product = await _productRepository.GetById(productId);

            if (product == null) return false;

            product.AddStock(quantity);

            _productRepository.Update(product);

            return await _productRepository.UnitOfWork.Commit();
        }

        public void Dispose()
        {
            _productRepository.Dispose();
        }
    }
}
