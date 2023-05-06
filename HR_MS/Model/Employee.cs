using System;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HR_MS.Model
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [MaxLength(25)]

        [Required]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Emial { get; set; }
        public string Address { get; set; }

        public Salary Salary { get; set; }

        public Department Department { get; set; }

    }
}
