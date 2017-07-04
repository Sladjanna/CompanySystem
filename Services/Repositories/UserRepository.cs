using DAL;
using Model;

namespace Services.Repositories
{
    public class UserRepository
    {
        public void Add(User user)
        {
            using (var ctx = new CompanyDbContext())
            {
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
        }
    }
}
