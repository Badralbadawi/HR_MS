 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_MS.Model
{
    public class Department
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string describtion { get; set; }
        public string type { get; set; }
        public string place { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        //public Salary Salary { get; set; }

    }
}
