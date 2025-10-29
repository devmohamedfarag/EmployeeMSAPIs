namespace EmployeeMS.Shared.DTOs
{
    public class ErrorDto(int statusCode, string message)
    {
        public int StatusCode { set; get; } = statusCode;
        public string Message { set; get; } = message; 
    }
}
