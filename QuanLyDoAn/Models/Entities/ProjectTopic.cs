namespace Project1.Models.Entities
{
    public class ProjectTopic
    {
        public int ProjectTopicID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
