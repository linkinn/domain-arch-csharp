using System.ComponentModel.DataAnnotations;

namespace NerdStore.Catalog.Application.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        public Guid CategoryId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        public DateTime RegisteredData { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        public string? Image { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The field {0} must have the min value {1}")]
        [Required(ErrorMessage = "The field {0} is mandatory")]
        public int StockQuantity { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The field {0} must have the min value {1}")]
        [Required(ErrorMessage = "The field {0} is mandatory")]
        public int Heigth { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The field {0} must have the min value {1}")]
        [Required(ErrorMessage = "The field {0} is mandatory")]
        public int Width { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The field {0} must have the min value {1}")]
        [Required(ErrorMessage = "The field {0} is mandatory")]
        public int Depth { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
