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

        [Required, RegularExpression(@"m|f")]
        [MaxLength(1)]
        public string Gender { get; set; }

        public DateTime Birthday { get; set; }

        [Required]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        [Required]
        public int TypeOfUserID { get; set; }
        public virtual TypeOfUser TypeOfUser { get; set; }

        #endregion Fields

        #region Constructor
        public User() { }
        #endregion Constructor
    }
}
