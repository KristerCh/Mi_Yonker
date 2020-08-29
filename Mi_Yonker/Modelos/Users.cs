using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mi_Yonker.Modelos
{
    public class Users
    {
        [Key]
        public int iduser { get; set; }
        public int usertype { get; set; }
        public int storeId { get; set; }
       
        [ForeignKey("storeId")]
        public virtual Stores Stores { get; set; }
    }
}
