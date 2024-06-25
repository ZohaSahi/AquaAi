using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AquaAi.shared.Models
{
    public class InvoiceDetails
    {
        [Key]
        [Required]
        public int InvoiceDetailId { get; set; }
        [Required]
        public int ItemId { get; set; }
        [Required]
        public int TotalAmount { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Attachments cannot exceed 255 characters")]
        public string? Attachments { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public int Subtotal { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Tax { get; set; }
        [Required]
        public string? Status { get; set; }
        // Foreign key property
        public int LiquidId { get; set; }
        public int InvoiceId { get; set; }
        // Navigation properties
        public Invoice? Invoice { get; set; }
        public Liquid? Liquid { get; set; }

    }
}
