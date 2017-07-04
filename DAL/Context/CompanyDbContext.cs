using Model;
using Model.Model;
using System.Data.Entity;

namespace DAL
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base()
        {
            this.Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new CompanyDbInitializer());
        }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasMany<Employee>(p => p.Employees);

            base.OnModelCreating(modelBuilder);
        }
    }
}
