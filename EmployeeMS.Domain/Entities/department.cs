﻿namespace EmployeeMS.Domain.Entities
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public ICollection<Employee> Employees { get; set; } 

    }
}
