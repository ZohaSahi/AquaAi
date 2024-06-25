using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AquaAi.shared.Models
{
    public class Product
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        public int? Quantity { get; set; }
        [Required]
        public string? LiquidType { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "ItemName cannot exceed 100 characters")]
        public string? ItemName { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? UnitPrice { get; set; }
        [Required]
        public int SupplierId { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        // Foreign key property
        public int LiquidId { get; set; }
        // Navigation property
        public Liquid? Liquid { get; set; }

    }
}
