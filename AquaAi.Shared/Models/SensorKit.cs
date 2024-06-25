using System.ComponentModel.DataAnnotations;

namespace AquaAi.shared.Models
{
    public class SensorKit
    {
        [Key]
        [Required]
        public int KitId { get; set; }
        [Required]
        public DateTime InstallationDate { get; set; }
        [Required]
        public string? Status { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        public string? SensorType { get; set; }
        // Foreign key property
        public int UserId { get; set; }
        public int LiquidId { get; set; }
        // Navigation property
        public List<SensorData>? SensorDataList { get; set; }
        public Liquid? Liquid { get; set; }

    }
}
