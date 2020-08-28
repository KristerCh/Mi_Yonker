using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi_Yonker.Models
{
    public class Vehicles
    {
        [ForeignKey("id")]
        public int id { get; set; }
        public int brand { get; set; }
        public int model { get; set; }
        public int year { get; set; }
        public virtual Models Models { get; set; }
    }
}
