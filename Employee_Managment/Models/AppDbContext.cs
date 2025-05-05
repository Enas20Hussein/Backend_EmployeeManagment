using Microsoft.EntityFrameworkCore;

namespace Employee_Managment.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FirstName = "Ahmed", LastName = "Mohamed", Email = "AhmedMo@gmail.com", Position = "Developer" },
                new Employee { Id = 2, FirstName = "Ali", LastName = "Ahmed", Email = "AliAhmed@gmail.com", Position = "Manager" }
            );
        }
    }

}
