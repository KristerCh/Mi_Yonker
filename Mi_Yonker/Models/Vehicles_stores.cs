using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi_Yonker.Models
{
    public class Vehicles_stores
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("id")]
        public virtual Vehicles Vehicles { get; set; }
        public int store { get; set; }
        public int vehicle { get; set; }
        public int stores_rtn { get; set; }
    }
}
