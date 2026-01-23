using Ebel.ValidatorKit.Validators;

namespace Ebel.ValidatorKit.Test.Validators;

[TestClass]
public sealed class CpfValidatorTests
{
    [TestMethod]
    public void Should_Fail_When_Cpf_Is_Empty()
    {
        string cpf = "";

        var result = cpf.ValidateCpf();

        Assert.IsFalse(result.IsValid);
        Assert.AreEqual("CPF is required", result.Message);
    }

    [TestMethod]
    public void Should_Fail_When_Cpf_Has_Less_Than_11_Digits()
    {
        string cpf = "123123";

        var result = cpf.ValidateCpf();

        Assert.IsFalse(result.IsValid);
    }

    [TestMethod]
    public void Should_Pass_When_Cpf_Has_11_Digits()
    {
        string cpf = "12312312312";

        var result = cpf.ValidateCpf();

        Assert.IsTrue(result.IsValid);
    }
}
