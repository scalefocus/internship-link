using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternshipLink.Web.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Името е задължително")]
        public string Name { get; set; }

        public string Email { get; set; }
        public string Message { get; set; }
        public int Age { get; set; }

        public bool IsAdult
        {
            get
            {
                return (Name != null) && (Email != null) && (Age < 18);
            }
        }
    }
}