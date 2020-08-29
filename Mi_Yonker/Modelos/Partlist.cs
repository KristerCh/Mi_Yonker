using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mi_Yonker.Modelos
{
    public class Partlist
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
