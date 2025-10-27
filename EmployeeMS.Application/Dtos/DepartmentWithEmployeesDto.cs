namespace EmployeeMS.Application.Dtos
{
    public class DepartmentWithEmployeesDto
    {
        public int DepartmentId { get; set; }
        public string DepartmentName {  get; set; }
        public List<EmployeeDto> Employees { get; set; }    
    }
}
