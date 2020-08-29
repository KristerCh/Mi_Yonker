using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Mi_Yonker.Models
{
    public class Stores
    {
        [Key]
        public int rtn { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public float latitue { get; set; }
        public float longitude { get; set; }
        public string owner { get; set; }
        public int owner_id { get; set; }
        public string contact_person { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string facebook { get; set; }
        public string website { get; set; }
    }
}
