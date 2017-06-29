using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new CompanyDbContext())
            {
                var r = ctx.Companies.ToList();
                var d = ctx.Departments.ToList();
                var t = ctx.TypeOfUsers.ToList();
                var u = ctx.Users.ToList();
                //foreach (var res in r)
                //{
                //    Console.WriteLine("done");
                //}

            }
        }
    }
}
