using Microsoft.EntityFrameworkCore;
using HR_MS.Model;

namespace HR_MS.Model
{
    public static class SeedEmployee
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    ID = 1,
                    Name = "Badr",
                    Address = "Sana'a",
                    Emial ="aa405716@gmail.com",
                    PhoneNumber="775010762"
                    
                },
                                new Employee
                                {
                                    ID = 2,
                                    Name = "Badr",
                                    Address = "Sana'a",
                                    Emial = "aa405716@gmail.com",
                                    PhoneNumber = "775010762"

                                },
                new Employee
                {
                    ID = 3,
                    Name = "Badr",
                    Address = "Sana'a",
                    Emial = "aa405716@gmail.com",
                    PhoneNumber = "775010762"

                },
                new Employee
                {
                    ID = 4,
                    Name = "Badr",
                    Address = "Sana'a",
                    Emial = "aa405716@gmail.com",
                    PhoneNumber = "775010762"

                },
                new Employee
                {
                    ID = 5,
                    Name = "Badr",
                    Address = "Sana'a",
                    Emial = "aa405716@gmail.com",
                    PhoneNumber = "775010762"

                }

            );
        }
    }
}
