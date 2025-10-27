namespace EmployeeMS.Domain.Entities
{
    public class Profession
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double AcceptedSalary { get; set; }

        public ICollection<Employee> Employees { get; set; }


    }
}
