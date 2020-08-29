using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi_Yonker.Modelos
{
    public class Parts_vehicle
    {
       [Key]
       public int id { get; set; }
       public int partId { get; set; }
       [ForeignKey("partId")]
       public virtual Partlist Partlist { get; set; }
       public int vehicleId { get; set; }
       [ForeignKey("vehicleId")]
       public virtual Vehicles Vehicles { get; set; }
    }
}
