using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCEmployee.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

    }
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }

}