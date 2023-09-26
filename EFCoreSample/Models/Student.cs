using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace EFCoreSample.Models
{
    public class Student
    {
        public string Id { get; set; }

        [StringLength(15, ErrorMessage ="First name must not be more than 15 characters", MinimumLength = 6)]
        public string FirstName { get; set; }

        [StringLength(15, ErrorMessage = "Last name must not be more than 15 characters", MinimumLength = 6)]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage = "Wrong Email Format")]
        public string Email { get; set; }
        public ICollection<Score> Scores { get; set; }

        public Student()
        {
            Scores = new HashSet<Score>();
        }
    }
}
