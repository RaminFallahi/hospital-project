using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hospital_project.Models
{
    public class Lot
    {
        [Key]
        public int lot_id { get; set; }
        public string lot_name { get; set; }
    }
}