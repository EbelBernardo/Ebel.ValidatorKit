namespace Ebel.ValidationKit.Results;

public class ValidationResult()
{
    public bool IsValid { get; set; }
    public string Message { get; set; } = string.Empty;

    public static ValidationResult Success()
        => new() { IsValid = true };

    public static ValidationResult Fail(string message)
        => new() { IsValid = false, Message = message };
}