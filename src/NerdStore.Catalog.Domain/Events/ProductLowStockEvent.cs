using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalog.Domain.Events
{
    public class ProductLowStockEvent : DomainEvent
    {
        public int QuantityRest {  get; private set; }
        public ProductLowStockEvent(Guid aggregateId, int quantityRest) : base(aggregateId)
        {
            QuantityRest = quantityRest;
        }
    }
}
