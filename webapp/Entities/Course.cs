using System.ComponentModel.DataAnnotations;

namespace webapp.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public int Seq { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public float Credit { get; set; }
    }
}
