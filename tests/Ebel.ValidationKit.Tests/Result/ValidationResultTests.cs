using Ebel.ValidationKit.Results;

namespace Ebel.ValidatorKit.Tests.Results;

[TestClass]
public sealed class ValidationResultTests
{
    [TestMethod]
    public void Success_Should_Return_IsValid_True_And_Empty_Message()
    {
        var result = ValidationResult.Success();

        Assert.IsTrue(result.IsValid);
        Assert.AreEqual(string.Empty, result.Message);
    }

    [TestMethod]
    public void Fail_Should_Return_IsValid_False_And_Message()
    {
        var errorMessage = "Error occurred";

        var result = ValidationResult.Fail(errorMessage);

        Assert.IsFalse(result.IsValid);
        Assert.AreEqual(errorMessage, result.Message);
    }
}