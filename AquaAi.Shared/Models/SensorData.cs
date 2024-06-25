using System.ComponentModel.DataAnnotations;

namespace AquaAi.shared.Models
{
    public class SensorData
    {
        [Key]
        [Required]
        public int SensorDataId { get; set; }
        [Required]
        [Range(0, 14, ErrorMessage = "PHLevel must be between 0 and 14")]
        public double PHLevel { get; set; }
        [Required]
        public double Conductivity { get; set; }
        [Required]
        public double Viscosity { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
        [Required]
        public double LiquidLevel { get; set; }
        // Foreign key
        public int KitId { get; set; }
        // Navigation property
        public SensorKit? SensorKit { get; set; }

    }
}
