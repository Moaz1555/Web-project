using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Maindb:DbContext
    {
       public DbSet<Project> Project {  get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<TeamMember> TeamMember { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ManageTasks;User ID=sa;Password=FIATS@2024;Trust Server Certificate=True;");
        }
    }
}
//Data Source=.;initial Catalog=ManageTasks;User ID=sa;Password=FIATS@2024;Trust Server Certificate=True;