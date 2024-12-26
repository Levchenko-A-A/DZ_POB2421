using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_32._2
{
    internal class Iris
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public double Sepallength { get; set; }
        [Required]
        public double SepalWidth { get; set; }
        [Required]
        public double Petallength { get; set; }
        [Required]
        public double PetalWidth { get; set; }
        [Required]
        public string? Variety { get; set; }
    }
}
