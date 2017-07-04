using Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Task
    {
        #region Fields
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EstimatedWorkingHour { get; set; }
        public int RemainingWorkingHour { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [RegularExpression(@"ToDo|InProgress|Done|Canceled")]
        public string StateOfTask { get; set; }

        [StringLength(150)]
        public string Comment { get; set; }

        public string TaskEmployee { get; set; }  // ???

        public int? EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        public string TasksProject { get; set; }    //????

        public int? ProjectID { get; set; }
        #endregion Fields

        #region Constructor
        public Task() { }

        public Task(string title, DateTime startDate, DateTime endDate, int estimated, int remainig, string description, string stateOfTask, string comment, int projectID, int userID)
        {
            this.Title = title;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.EstimatedWorkingHour = estimated;
            this.RemainingWorkingHour = remainig;
            this.Description = description;
            this.StateOfTask = stateOfTask;
            this.Comment = comment;
            this.ProjectID = projectID;
            this.EmployeeID = userID;
        }

        #endregion Constructor
    }
}
