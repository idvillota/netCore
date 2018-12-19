namespace EntityFrameworkTutorial.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public EGrade? Grade { get; set; }

        public Course Course { get; set; }

        public Student Student { get; set; }
    }
}