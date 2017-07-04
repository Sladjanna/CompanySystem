using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public sealed class Company
    {
        #region Fields
        private static Company _company;
        public Dictionary<int, User> Users { get; set; }
        public Dictionary<int, Department> Departments { get; set; }   
        public Dictionary<int, Project> Projects { get; set; }
        public User CurrentUser { get; set; }

        public static Company Instance
        {
            get
            {
                if (_company == null)
                {
                    _company = new Company();
                }

                return _company;
            }
        }
        #endregion Fields

        #region Constructors
        private Company() { }
        #endregion Constructors
    }
}
