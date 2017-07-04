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
        public bool isDepartmentActive { get; set; }
        #endregion Fields

        #region Constructor
        public Department() { }

        public override string ToString()
        {
            return Name;
        }
        #endregion Constructor
    }
}
