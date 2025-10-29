namespace EmployeeMS.Shared.DTOs
{
    // primary constryctor
    public class ErrorDtoint( int statusCode, string message)
    {
        public int StatusCode { set; get; } = statusCode;
        public string Message { set; get; } = message; 
    }
}
