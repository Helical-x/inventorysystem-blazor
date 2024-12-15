using System.ComponentModel.DataAnnotations;
using BlazorBootstrap;

namespace InventorySystemV2.Models;

public class DisplayProduct
{
    public int? Id { get; set; }
    [MinLength(5), MaxLength(50)]
    public string Name { get; set; }
    public string Description { get; set; }
    
    [Range(0, Int32.MaxValue)]
    public decimal Price { get; set; }
    [Range(0, Int32.MaxValue)]
    public int Quantity { get; set; }
    public String ImageUrl { get; set; }
    
}