using Model;
using Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class ProjectModel
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

            public int DepartmentID { get; set; }
            [ForeignKey("DepartmentID")]
            public virtual Department Department { get; set; }

            public int ManagerID { get; set; }
            public virtual List<Employee> Employees { get; set; }
            #endregion Fields

            #region Constructor
            public Project() { }

            #endregion Constructor
        }
    }
}