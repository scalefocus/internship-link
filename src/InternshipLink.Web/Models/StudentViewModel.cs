using System.ComponentModel.DataAnnotations;

namespace InternshipLink.Web.Models
{
    public class StudentViewModel
    {
        public long ID { get; set; }

        [Required, MaxLength(40)]
        public string FirstName { get; set; }

        [MaxLength(40)]
        public string LastName { get; set; }
    }
}