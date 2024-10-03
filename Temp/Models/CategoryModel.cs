using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Temp.Models
{
    public class CategoryModel
    {
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(30, ErrorMessage = "Enter Length Should be under 30 char")]
        public string ?Name { get; set; }

        [DisplayName("Display Order"), Range(1, 100, ErrorMessage = "Enter between 1 Or 100")]
        public int DisplayOrder { get; set; }
    }
}
