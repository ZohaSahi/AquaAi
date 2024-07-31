using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaAi.Shared.Models
{
    public class SensorData
    {
        [Key]
        [Required]
        public int SensorDataId { get; set; }

        [Required]
        public double Conductivity { get; set; }
        [Required]
        public double Viscosity { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
        [Required]
        public double LiquidLevel { get; set; }

    }
}
