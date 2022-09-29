namespace WebAPI.Models;

public class ErrorDto
{
    public object Content { get; set; }
    public bool IsSuccess { get; set; }
    public int Code { get; set; }
    public string ErrorMessage { get; set; }
}