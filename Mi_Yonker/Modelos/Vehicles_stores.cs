using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi_Yonker.Modelos
{
    public class Vehicles_stores
    {
        [Key]
        public int id { get; set; }
        public int storeId { get; set; }
        [ForeignKey("storeId")]
        public virtual Stores Stores { get; set; }
        public int vehicleId { get; set; }
        [ForeignKey("vehicleId")]
        public virtual Vehicles Vehicles { get; set; }
    }
}
