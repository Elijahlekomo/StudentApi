using Microsoft.EntityFrameworkCore;

namespace StudentApi.Controllers.Models
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions option):base(option) 
        {
        }

        public DbSet<Student>Students { get; set; }
    }
}
