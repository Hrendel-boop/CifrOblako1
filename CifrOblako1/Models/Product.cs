using System.ComponentModel.DataAnnotations;

namespace CifrOblako1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Некорректное Значение!")]
        public int Price { get; set; }
    }
}
