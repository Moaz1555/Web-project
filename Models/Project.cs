using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public List<Tasks> tasks { get; set; }
    }
}
