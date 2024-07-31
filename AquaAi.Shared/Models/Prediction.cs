using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML.Data;
namespace AquaAi.Shared.Models
{
    [Keyless]
    public class Prediction
    {
        [ColumnName("Quantity")]
        public float Quantity { get; set; }  
    }
}
