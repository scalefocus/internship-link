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
        public long ID { get; set; }

        [Required, MaxLength(40)]
        public string FirstName { get; set; }

        [MaxLength(40)]
        public string LastName { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }


        //public bool Active { get; set; } = true;

        //public DateTime CreatedOn { get; set; } = DateTime.Now;

        //public string CreateBy { get; set; }

        //public DateTime ModifiedOn { get; set; } = DateTime.Now;

        //public string ModifiedBy { get; set; }
    }
}