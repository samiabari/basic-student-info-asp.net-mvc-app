namespace StudentInfoMVC.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public Teacher Teacher { get; set; } 
        public int TeacherId { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();

    }
}
