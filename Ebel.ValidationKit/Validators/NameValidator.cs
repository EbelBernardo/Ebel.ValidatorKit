using System.Net.Mail;
using Ebel.ValidatorKit.Results;

namespace Ebel.ValidatorKit.Validators;

public static class NameValidator
{
    public static ValidationResult ValidateName(this string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return ValidationResult.Fail("Name is required");

        foreach (var c in name)
        {
            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                return ValidationResult.Fail("Name should not have special characters");
        }

        return ValidationResult.Success();
    }
}
