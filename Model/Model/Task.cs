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

        [Required, RegularExpression(@"ToDo|InProgress|Done|Canceled")]
        public string StateOfTask { get; set; }

        [StringLength(150)]
        public string Comment { get; set; }
        public Project ProjectID { get; set; }
        public User UserID { get; set; }
        #endregion Fields

        #region Constructor
        public Task() { }
        #endregion Constructor
    }
}
