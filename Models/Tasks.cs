using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        [MaxLength (100)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public string Status { get; set; }
        public string priority { get; set; }
        public DateTime DeadLine { get; set; }
        [ForeignKey("TeamMember")]
        public int MemberId { get; set; }
        [ForeignKey("Project")]
       public int  ProjectId { get; set; }

         public TeamMember TeamMember { get; set; }
        public Project Project { get; set; }


    }
}
