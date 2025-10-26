namespace EmployeeMS.Application.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double Salary { get; set; }
        public DateTime JoinDate { get; set; }
        public int DepartmentId {  get; set; }
        public int ProfessionId {  get; set; }
    }
}
