
namespace BuberBreakfast.Contracts.Error;

public class ErrorResponse
{

    public string Status { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public object Errors { get; set; } = string.Empty;

}