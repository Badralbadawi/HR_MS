using Microsoft.EntityFrameworkCore;
using HR_MS.Model;

namespace HR_MS.Model
{
    public static class SeedDepatment
    {
        public static void Seed2(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    ID = 1,
                    Name = "Badr",
                    type = "Partial",
                    describtion="jdklajsflkhflkahsfa",
                    place ="Online"
                    
                },
                                new Department
                                {
                                    ID = 2,
                                    Name = "Badr",
                                    type = "Partial",
                                    describtion = "jdklajsflkhflkahsfa",

                                    place = "Online"

                                },
                new Department
                {
                    ID = 3,
                    Name = "Badr",
                    type = "Partial",
                    describtion = "jdklajsflkhflkahsfa",

                    place = "Online"

                },
                new Department
                {
                    ID = 4,
                    Name = "Badr",
                    type = "Partial",
                    describtion = "jdklajsflkhflkahsfa",

                    place = "Online"

                },
                new Department
                {
                    ID = 5,
                    Name = "Badr",
                    type = "Partial",
                    describtion = "jdklajsflkhflkahsfa",

                    place = "Online"

                }


            );
        }
    }
}
