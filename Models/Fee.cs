using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hospital_project.Models
{
    public class Fee
    {
        [Key]
        public int fee_id { get; set; }
        public string fee_name { get; set; }
        public int price { get; set; }
    }
}