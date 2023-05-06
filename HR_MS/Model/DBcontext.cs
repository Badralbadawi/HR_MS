using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel;
using Microsoft.EntityFrameworkCore;
using System;

using HR_MS.Model;

namespace HR_MS.DBContext
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext()
        {
        }
        public DataBaseContext(DbContextOptions _options) //: base(options)
        {
            
            

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=HRMSB1;Integrated Security=True");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            modelBuilder.Seed2();
            modelBuilder.Seed3();



        }
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Salary> Salari { get; set; }
        public virtual DbSet<Department> epartments { get; set; }



    }
}
 