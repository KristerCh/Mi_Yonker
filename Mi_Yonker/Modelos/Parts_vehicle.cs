using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi_Yonker.Models
{
    public class Parts_vehicle
    {
        [Key]
       public int id { get; set; }
       [ForeignKey("part")]
       public int part { get; set; }
       [ForeignKey("vehicle")]
       public int vehicle { get; set; }
    }
}
