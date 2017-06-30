using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Department
    {
        #region Fields
        public int Id { get; set; }
        public string Name { get; set; }

        [StringLength(150)]
        public string Description { get; set; }
        public bool Active { get; set; }

        [Required]
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
        #endregion Fields

        #region Constructor
        public Department() { }
        #endregion Constructor
    }
}
