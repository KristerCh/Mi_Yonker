using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi_Yonker.Modelos
{
    public class Vehicles
    {
        [Key]
        public int id { get; set; }
        public int brandId { get; set; }
        [ForeignKey("brandId")]
        public virtual Brands Brands { get; set; }
        public int year { get; set; }
        public int modelId { get; set; }
        [ForeignKey("modelId")]
        public virtual Models Models { get; set; }
    }
}
