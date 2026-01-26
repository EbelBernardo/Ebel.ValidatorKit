using Ebel.ValidationKit.Validators;

namespace Ebel.ValidatorKit.Test.Validators;

[TestClass]
public sealed class NameValidatorTests
{
    [TestMethod]
    public void Should_Fail_When_Name_Is_Empty()
    {
        string name = "";

        var result = name.ValidateName();

        Assert.IsFalse(result.IsValid);
    }

    [TestMethod]
    public void Should_Fail_When_Name_Has_Special_Characters()
    {
        string name = "João123";

        var result = name.ValidateName();

        Assert.IsFalse(result.IsValid);
    }

    [TestMethod]
    public void Should_Pass_When_Name_Is_Valid()
    {
        string name = "João";

        var result = name.ValidateName();

        Assert.IsTrue(result.IsValid);
    }
}