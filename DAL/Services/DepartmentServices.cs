using Model;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Services
{
    class DepartmentServices
    {
        public static List<Department> GetDepartments()
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Departments.ToList();
            }
        }
    }
}
