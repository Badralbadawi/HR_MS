﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_MS.Model
{
    public class Salary
    {
        public int Id { get; set; }
        public string type { get; set; }
        public string amt { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        //public Department Departments { get; set; }


    }

}
