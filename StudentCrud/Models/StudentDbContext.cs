using Microsoft.EntityFrameworkCore;

namespace StudentCrud.Models
{
    public class StudentDbContext : DbContext
    {
        //created below databases
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =(local)\\sqlexpress; Database=lbs; Trusted_Connection=True; MultipleActiveResultSets=True;TrustServerCertificate=True;Encrypt=True");

            //"StudentDbContext": "Data Source=.; Initial Catalog=lbs;Trusted_Connection=True;MultipleActiveResultSets=True; Integrated Security=True; TrustServerCertificate=True"

        }
    }
}
