using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AquaAi.shared.Models
{
    public class BillDetails
    {
        [Key]
        public int BillDetailId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Subtotal { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal TotalAmount { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int ItemId { get; set; }
        [Required]
        public int Tax { get; set; }
        // Foreign key property
        public int LiquidId { get; set; }
        public int BillId { get; set; }
        // Navigation properties
        public Bill? Bill { get; set; }
        public Liquid? Liquid { get; set; }


    }
}
