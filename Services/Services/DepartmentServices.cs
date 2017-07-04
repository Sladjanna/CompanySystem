using DAL;
using Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Services
{
    public class DepartmentServices
    {
        public List<Department> GetAllDepartments()
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Departments.ToList();
            }
        }

        public Department GetDepartmentByID(int departmentId)
        {
            using (var ctx = new CompanyDbContext())
            {
                return ctx.Departments.SingleOrDefault(s => s.Id == (int)departmentId);
            }
        }

        public Department InsertDepartment(Department department)
        {
            using (var ctx = new CompanyDbContext())
            {
                var newDepartment = ctx.Departments.Add(department);
                ctx.SaveChanges();
                return newDepartment;
            }
        }

        public bool UpdateDepartment(Department department)
        {
            Department departmentForUpdate;
            using (var ctx = new CompanyDbContext())
            {
                departmentForUpdate = ctx.Departments.Where(x => x.Id == department.Id).FirstOrDefault<Department>();
                if (departmentForUpdate != null)
                {
                    departmentForUpdate.Name = department.Name;
                    departmentForUpdate.Description = department.Description;
                    departmentForUpdate.isDepartmentActive = department.isDepartmentActive;
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public void deleteDepartment(Department dep)
        {
            using (var ctx = new CompanyDbContext())
            {
                ctx.Departments.Remove(dep);
                ctx.SaveChanges();
            }
        }

    }
}
