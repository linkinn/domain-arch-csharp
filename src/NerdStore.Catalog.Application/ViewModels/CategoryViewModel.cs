using System.ComponentModel.DataAnnotations;

namespace NerdStore.Catalog.Application.ViewModels
{
    public class CategoryViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        public int Code { get; set; }
    }
}
