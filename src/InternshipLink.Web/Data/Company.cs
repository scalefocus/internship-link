using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternshipLink.Web.Data
{
    public class Company
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(80)]
        public string Name { get; set; }

        public int NumberOfEmployees { get; set; }
    }
}