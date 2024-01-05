using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalog.Domain
{
    public class Category : Entity
    {
        public string? Name { get; private set; }
        public int Code { get; private set;}
        public ICollection<Product> Products { get; private set; }

        protected Category() { }

        public Category(string name, int code)
        {
            Name = name;
            Code = code;

            Validate();
        }

        public override string ToString()
        {
            return $"{Name} - {Code}";
        }

        public void Validate()
        {
            Validations.ValidateIsEmpty(Name, "The category name field can't be empty");
            Validations.ValidateIsEqual(Code, 0,"The category code field can't be 0");
        }
    }
}
