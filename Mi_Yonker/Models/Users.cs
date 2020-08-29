using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mi_Yonker.Models
{
    public class Users
    {
        [Key]
        public int iduser { get; set; }
        public int usertype { get; set; }
        public int storeid { get; set; }
       
        [ForeignKey("store_rtn")]
        public int store_rtn { get; set; }
        public virtual Stores Stores { get; set; }
    }
}
