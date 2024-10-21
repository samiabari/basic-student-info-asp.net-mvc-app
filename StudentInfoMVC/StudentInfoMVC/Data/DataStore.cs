using StudentInfoMVC.Models;

namespace StudentInfoMVC.Data
{
    public static class DataStore
    {
        public static List<Student> Students = new List<Student>
        {
            new Student{ StudentId=1, StudentName="Samia"},
             new Student{ StudentId=2, StudentName="Shanta"},
              new Student{ StudentId=3, StudentName="Shohan"},
               new Student{ StudentId=4, StudentName="Rafa"}
        };

        public static List<Teacher> Teachers = new List<Teacher>
        {
            new Teacher{ TeacherId=1, TeacherName="Khaled"},
             new Teacher{ TeacherId=2, TeacherName="Aziz"},
              new Teacher{ TeacherId=3, TeacherName="Kabir"},
               new Teacher{ TeacherId=4, TeacherName="Sohel"}
        };

        public static List<Course> Courses = new List<Course>
        {
            new Course{ CourseId=1, CourseName="UI/UX", TeacherId=1, Teacher = Teachers[0], Students = new List<Student> { Students[0], Students[1], Students[2] }},
             new Course{ CourseId=2, CourseName="Database", TeacherId=1,  Teacher = Teachers[0], Students = new List<Student> { Students[1]}},
              new Course{ CourseId=3, CourseName="Project Management", TeacherId = 2,  Teacher = Teachers[1], Students = new List<Student> { Students[2]} },
               new Course{ CourseId=4, CourseName="React", TeacherId = 4,  Teacher = Teachers[3], Students = new List<Student> { Students[1], Students[0] } },
                new Course{ CourseId=5, CourseName="Asp.Net", TeacherId = 3,  Teacher = Teachers[2], Students = new List<Student> { Students[2] } },
                 new Course{ CourseId=6, CourseName="Java", TeacherId = 3,  Teacher = Teachers[2], Students = new List<Student> { Students[3]} }

        };

        static DataStore()
        {
            foreach (Course course in Courses)
            {
                foreach (Student student in course.Students)
                {
                    student.Courses.Add(course);
                }
            }
        }
    }
}
