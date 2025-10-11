using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public double Salary { get; set; }

        public DateTime JoinDate { get; set; }


        public int ProfessionId { get; set; }

        public int DepartmentId { get; set; }

        public Profession Profession { get; set; }

        public Department Department { get; set; }


    }
}

