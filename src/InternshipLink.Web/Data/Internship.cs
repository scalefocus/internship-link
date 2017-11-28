using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InternshipLink.Web.Data
{
    public class Internship
    {
        [Key]
        public int ID { get; set; }

        [Required,StringLength(100)]
        public string Name { get; set; }

        [Required,DataType(DataType.Date)]
        public int StartDate { get; set; }

        [Required, DataType(DataType.Date)]
        public int EndDate { get; set; }

        public long StudentID { get; set; }
        public int CompanyID { get; set; }

        [ForeignKey(nameof(StudentID))]
        public virtual ICollection<Student> Student { get; set; }

        [ForeignKey(nameof(CompanyID))]
        public virtual ICollection<Company> Company { get; set; }
    }
}