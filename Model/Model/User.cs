using Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        #region Fields
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [RegularExpression(@"m|f")]
        [MaxLength(1)]
        public string Gender { get; set; }

        public DateTime Birthday { get; set; }

        public UserType UserType { get; set; }

        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }

        public List<Project> Projects { get; set; }
        #endregion Fields

        #region Constructor
        public User()  {  }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        #endregion Constructor
    }
}
