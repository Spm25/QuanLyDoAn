namespace Project1.Models.Entities
{
    public class Student
    {
        public int StudentID { get; set; } // Mã sinh viên
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; } // Mật khẩu (bắt đầu bằng mã sinh viên)
        public string ProjectBatch { get; set; }

        // Thông tin đăng ký đồ án
        public int? ProjectTopicID { get; set; }
        public ProjectTopic ProjectTopic { get; set; }

        public int? TeacherID { get; set; }
        public Teacher Teacher { get; set; }
    }
}
