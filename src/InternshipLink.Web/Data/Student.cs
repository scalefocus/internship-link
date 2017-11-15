using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternshipLink.Web.Data
{
    public class Student
    {
        [Key]
        public long Number { get; set; }

        [Required, MaxLength(40)]
        public string FirstName { get; set; }

        [MaxLength(40)]
        public string LastName { get; set; }

    }
}