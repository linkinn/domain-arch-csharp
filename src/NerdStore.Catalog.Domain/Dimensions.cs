using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalog.Domain
{
    public class Dimensions
    {
        public decimal Heigth { get; private set; }
        public decimal Width { get; private set;}
        public decimal Depth { get; private set;}

        public Dimensions(decimal heigth, decimal width, decimal depth)
        {
            Heigth = heigth;
            Width = width;
            Depth = depth;

            Validate();
        }

        public string DimensionsDescription()
        {
            return $"HxWxD: {Heigth} x {Width} x {Depth}";
        }

        public override string ToString()
        {
            return DimensionsDescription();
        }

        public void Validate()
        {
            Validations.ValidateIfMinEqualMax(Heigth, 0, "The heigth field cannot be less than or equal 0");
            Validations.ValidateIfMinEqualMax(Width, 0, "The width field cannot be less than or equal 0");
            Validations.ValidateIfMinEqualMax(Depth, 0, "The depth field cannot be less than or equal 0");
        }
    }
}
