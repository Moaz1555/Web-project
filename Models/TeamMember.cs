using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class TeamMember
    {
        [Key]
        public int MemberId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Role { get; set; }
        public List<Tasks> tasks { get; set; }
    }
}
