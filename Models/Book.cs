using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hospital_project.Models
{
    public class Book
    {
        [Key]
        public int book_id { get; set; }
        public int lot_id { get; set; }
        public int fee_id { get; set; }
        public DateTime date { get; set; }
        public int price { get; set; }

    }
}