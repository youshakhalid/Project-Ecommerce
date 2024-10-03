using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectEcommerce.Models.Models

{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Enter a Number Between 1 - 100")]
        public int DisplayOrder { get; set; }
    }
}
