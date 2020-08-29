using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi_Yonker.Models
{
    public class Models
    {
        [Key]
        public int id { get; set; }
        public string model { get; set; }
    }
}
