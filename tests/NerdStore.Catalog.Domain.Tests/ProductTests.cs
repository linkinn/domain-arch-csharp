using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalog.Domain.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Product_Validate_ValidationsMustReturnExceptions()
        {
            var ex = Assert.Throws<DomainException>(() => 
                new Product(string.Empty, "Description", false, 100, Guid.NewGuid(), DateTime.Now, "Image", new Dimensions(1, 1, 1))
            );

            Assert.Equal("The product name field can't be empty", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Product("Name", string.Empty, false, 100, Guid.NewGuid(), DateTime.Now, "Image", new Dimensions(1, 1, 1))
            );

            Assert.Equal("The product description field can't be empty", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Product("Name", "Description", false, 0, Guid.NewGuid(), DateTime.Now, "Image", new Dimensions(1, 1, 1))
            );

            Assert.Equal("The product price field can't be less than or equal to 0", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Product("Name", "Description", false, 100, Guid.Empty, DateTime.Now, "Image", new Dimensions(1, 1, 1))
            );

            Assert.Equal("The product categoryID can't be is empty", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Product("Name", "Description", false, 100, Guid.NewGuid(), DateTime.Now, string.Empty, new Dimensions(1, 1, 1))
            );

            Assert.Equal("The product image field can't be empty", ex.Message);
        }
    }
}