using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AquaAi.shared.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        [Required]
        public DateTime InvoiceDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal TotalAmount { get; set; }
        [Required]
        public string? PaymentStatus { get; set; }
        // Foreign key property
        public int CustomerId { get; set; }
        // Navigation property
        public List<InvoiceDetails>? InvoiceDetails { get; set; }

    }
}
