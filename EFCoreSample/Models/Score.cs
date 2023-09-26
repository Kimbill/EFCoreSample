using System.ComponentModel.DataAnnotations;

namespace EFCoreSample.Models
{
    public class Score
    {

        public int Id { get; set; }

        [Range(0, 40)]
        [Required]
        public double Test { get; set; }

        [Range(0, 100)]
        [Required]
        public double Exams { get; set; }

        public string StudentId { get; set; }

        public Student Student { get; set; }
    }
}