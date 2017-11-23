using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternshipLink.Web.Data
{
    public class Major
    {
        [Key]
        public int MajorID { get; set; }

        [Required,MaxLength(40)]
        public string Name { get; set; }
    }
}