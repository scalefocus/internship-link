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

        [EmailAddress,StringLength(100)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public string Phone { get; set; }
        
        public string Address { get; set; }

        public string City { get; set; }


    }
}