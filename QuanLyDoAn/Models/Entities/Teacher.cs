namespace Project1.Models.Entities
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public int MaxStudents { get; set; }
        public string Specialties { get; set; } // Các hướng có thể hướng dẫn

        public ICollection<Student> Students { get; set; }
    }
}
