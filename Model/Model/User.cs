using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required, RegularExpression(@"m|f")]
        public char Gender { get; set; }

        public DateTime Birthday { get; set; }
        public Department DepartmentID { get; set; }
        public TypeOfUser TypeOfUserID { get; set; }
        #endregion Fields

        #region Constructor
        public User() { }
        #endregion Constructor
    }
}
