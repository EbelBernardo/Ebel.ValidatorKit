using Ebel.ValidationKit.Results;

namespace Ebel.ValidationKit.Validators;

public static class CpfValidator
{
    public static ValidationResult ValidateCpf(this string cpf)
    {
        if (string.IsNullOrEmpty(cpf))
            return ValidationResult.Fail("CPF is required");

        var cleaned = new string(cpf.Where(char.IsDigit).ToArray());
        if (cleaned.Length != 11)
            return ValidationResult.Fail("CPF should have 11 digits");

        return ValidationResult.Success();
    }
}