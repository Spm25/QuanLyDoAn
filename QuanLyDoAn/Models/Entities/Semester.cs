namespace Project1.Models.Entities
{
    public class Semester
    {
        public int SemesterID { get; set; }
        public string SemesterName { get; set; }
        public string ProjectBatch { get; set; } // Chính quy, Liên thông
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
