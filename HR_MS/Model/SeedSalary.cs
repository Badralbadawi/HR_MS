using Microsoft.EntityFrameworkCore;
using HR_MS.Model;

namespace HR_MS.Model
{
    public static class SeedSalary
    {
        public static void Seed3(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salary>().HasData(
                new Salary
                {
                    Id = 1,
                    amt = "Badr",
                    type = "Manager"
                },
                new Salary
                {
                    Id = 3,
                    amt = "Badr",
                    type = "Manager"
                },
                new Salary
                {
                    Id = 4,
                    amt = "Badr",
                    type = "Manager"
                },
                new Salary
                {
                    Id = 5,
                    amt = "Badr",
                    type = "Manager"
                }

            );
        }
    }
}
