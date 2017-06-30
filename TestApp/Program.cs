using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {
            using (var ctx = new CompanyDbContext())
            {
                var r = ctx.Companies.ToList();
                var d = ctx.Departments.ToList();
                var tu = ctx.TypeOfUsers.ToList();
                var u = ctx.Users.ToList();
             //   var p = ctx.Projects.ToList();
             //   var ta = ctx.Tasks.ToList();
                //foreach (var res in r)
                //{
                //    Console.WriteLine("done");
                //}

            }
        }
    }
}
