using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mery",
                    Department = Dept.HR,
                    Email = "mery@meta.ua"
                },
                new Employee
                {
                    Id = 2,
                    Name = "John",
                    Department = Dept.IT,
                    Email = "john@meta.ua"
                },
                new Employee
                {
                    Id = 3,
                    Name = "Mark",
                    Department = Dept.IT,
                    Email = "mark@meta.ua"
                }
                );
        }
    }
}
