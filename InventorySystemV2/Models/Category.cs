using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InventorySystemV2.Models;

namespace InventorySystemV2.Models;
public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    // Navigation properties
    public ICollection<Product> Products { get; set; }

}
