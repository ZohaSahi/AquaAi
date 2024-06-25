using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AquaAi.shared.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "PaymentStatus cannot exceed 50 characters")]
        public string? PaymentStatus { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal TotalAmount { get; set; }
        [Required]
        public DateTime BillDate { get; set; }
        // Foreign key property
        public int VendorId { get; set; }
        // Navigation property
        public List<BillDetails>? BillDetails { get; set; }
    }
}
