using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AquaAi.shared.Models
{
    public class Liquid
    {
        [Key]
        public int LiquidId { get; set; }
               [Required]
        [MaxLength(50, ErrorMessage = "LiquidName cannot exceed 50 characters")]
        public string? LiquidName { get; set; }
        [Required]
        public double Length { get; set; }
        [Required]
        public double Width { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Liquid_price { get; set; }
        // Foreign key property
        public int KitId { get; set; }
        // Navigation properties
        public SensorKit? SensorKit { get; set; }
        public List<Product>? Inventory { get; set; }
        public List<BillDetails>? BillDetails { get; set; }
        public List<InvoiceDetails>? InvoiceDetails { get; set; }

    }
}
