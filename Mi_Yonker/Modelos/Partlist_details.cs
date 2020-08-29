using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mi_Yonker.Models
{
    public class Partlist_details
    {
        [Key]
        public int id { get;set; }
        [ForeignKey("idpart")]
        public virtual Partlist Partlist { get; set; } 
        public int idpart { get; set; }
        public int detail { get; set; }

    }
}
