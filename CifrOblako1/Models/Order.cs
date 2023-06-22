using System.ComponentModel.DataAnnotations.Schema;

namespace CifrOblako1.Models
{
    public class Orders
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
