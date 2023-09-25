namespace EFCoreSample.Models
{
    public class Score
    {

        public int Id { get; set; }
        public double Test { get; set; }
        public double Exams { get; set; }

        public string StudentId { get; set; }

        public Student Student { get; set; }
    }
}