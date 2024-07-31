using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace AquaAi.Shared.Models
{
    [Keyless]
    public class Test
    {
        [LoadColumn(0)]
        public string? Date { get; set; }  // Changed to property

        [LoadColumn(1)]
        public float Code { get; set; }  // Changed to property

        [LoadColumn(2)]
        public float Quantity { get; set; }  // Changed to property

        [LoadColumn(3)]
        public float Rate { get; set; }  // Changed to property

        [LoadColumn(4)]
        public float TotalAmount { get; set; }  // Changed to property
    }

    public class TransformedTest
    {
        public float DayOfWeek { get; set; }  // Changed to property
        public float Month { get; set; }  // Changed to property
        public float Year { get; set; }  // Changed to property
        public float Quantity { get; set; }  // Changed to property
    }

}
