using System.Diagnostics;
using NerdStore.Core.DomainObjects;
using static System.Net.Mime.MediaTypeNames;

namespace NerdStore.Catalog.Domain
{
    public class Product : Entity, IAggregateRoot
    {
        public Guid CategoryId {  get; private set; }
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public bool Active { get; private set; }
        public decimal Price { get; private set; }
        public DateTime RegisteredData { get; private set; }
        public string? Image { get; private set; }
        public int StockQuantity { get; private set; }
        public Dimensions Dimensions { get; private set; }
        public Category? Category { get; private set; }

        public Product(string name, string description, bool active, decimal price, Guid categoryId, DateTime registeredData, string image, Dimensions dimensions)
        {
            Name = name;
            Description = description;
            Active = active;
            Price = price;
            CategoryId = categoryId;
            RegisteredData = registeredData;
            Image = image;
            Dimensions = dimensions;

            Validate();
        }

        public void Activate() => Active = true;

        public void Deactivate() => Active = false;

        public void UpdateCategory(Category category)
        {
            Category = category;
            CategoryId = category.Id;
        }

        public void UpdateDescription(string description)
        {
            Description = description;
        }

        public void DebitStock(int quantity)
        {
            if (quantity < 0) quantity *= -1;
            StockQuantity -= quantity;
        }

        public void AddStock(int quantity)
        {
            StockQuantity += quantity;
        }

        public bool ExistStock(int quantity)
        {
            return StockQuantity >= quantity;
        }

        public void Validate()
        {
            Validations.ValidateIsEmpty(Name, "The product name field can't be empty");
            Validations.ValidateIsEmpty(Description, "The product description field can't be empty");
            Validations.ValidateIsDifferent(CategoryId, Guid.Empty, "The product categoryID can't be is empty");
            Validations.ValidateIfMinEqualMax(Price, 0, "The product price field can't be less than or equal to 0");
            Validations.ValidateIsEmpty(Image, "The product image field can't be empty");
        }
    }
}
