using Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public bool Delayed { get; set; }

        [Required]
        public int DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }

        [Required]
        public int ManagerID { get; set; }
        public virtual List<Employee> Employees { get; set; }

        #endregion Fields

        #region Constructor
        public Project() { }

        #endregion Constructor
    }
}
