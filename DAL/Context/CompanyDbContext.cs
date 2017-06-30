using Model;
using System.Data.Entity;

namespace DAL
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base()
        {
            Database.SetInitializer(new CompanyDbInitializer());
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments{ get; set; }
     //   public DbSet<Project> Projects { get; set; }
    //    public DbSet<Task> Tasks { get; set; }
        public DbSet<TypeOfUser> TypeOfUsers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
