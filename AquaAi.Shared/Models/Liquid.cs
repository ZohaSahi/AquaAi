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
        public string? Width { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Liquid_price { get; set; }
       
    }
}
