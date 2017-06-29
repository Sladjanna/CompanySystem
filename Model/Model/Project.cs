using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Project
    {
        #region Fields
        public int Id { get; set; }
        public string Title { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public decimal Cost { get; set; }

        [Required, RegularExpression(@"New|InProgress|Finished|Canceled")]
        public string StateOfProject { get; set; }

        [Required]
        public Department DepartmentID { get; set; }
        public User ManagerID { get; set; }
        #endregion Fields

        #region Constructor
        public Project() { }
        #endregion Constructor
    }
}
