using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string MiddleName { get; set; }

        public  int? StartYear { get; set; }

        
        public int MajorID { get; set; }

        
        public int? Group { get; set; }

        [MaxLength(40)]
        public string LastName { get; set; }

        [ForeignKey(nameof(MajorID))]
        public Major Major { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }

        public int UserID { get; set; }

        [ForeignKey(nameof(UserID))]
        public ApplicationUser User;


        //public bool Active { get; set; } = true;

        //public DateTime CreatedOn { get; set; } = DateTime.Now;

        //public string CreateBy { get; set; }

        //public DateTime ModifiedOn { get; set; } = DateTime.Now;

        //public string ModifiedBy { get; set; }
    }
}