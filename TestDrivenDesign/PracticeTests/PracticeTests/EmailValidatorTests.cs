using SomeCSharpPractice;

namespace PracticeTests;

public class EmailValidatorTests
{
    [Test]
    public void ValidateEmailWithNull()
    {
        var emailWithNull = "";
        Assert.That(EmailValidator.ValidateEmail(emailWithNull), Is.False);
    }

    [Test]
    public void ValidateEmailWithWhiteSpace()
    {
        var emailWithWhiteSpace = " ";
        Assert.That(EmailValidator.ValidateEmail(emailWithWhiteSpace), Is.False);
    }

    [Test]
    public void ValidateEmailWithTwoAtSymbols()
    {
        var emailWithTwoAtSymbols = "this@email@twosymbols.com";
        Assert.That(EmailValidator.ValidateEmail(emailWithTwoAtSymbols), Is.False);
    }

    [Test]
    public void ValidateEmailWithLocalPartEmpty()
    {
        var emailWithLocalPartEmpty = "@localempty.com";
        Assert.That(EmailValidator.ValidateEmail(emailWithLocalPartEmpty), Is.False);
    }

    [Test]
    public void ValidateEmailWithDomainPartEmpty()
    {
        var emailWithDomainPartEmpty = "domainempty@.com";
        Assert.That(EmailValidator.ValidateEmail(emailWithDomainPartEmpty), Is.False);
    }

    [Test]
    public void ValidateEmailWithInvalidLocalPart()
    {
        var emailWithInvalidLocalPart = new[] {"#@domain.com", "$@domain.com", "&@domain.com"};

        foreach (var email in emailWithInvalidLocalPart)
        {
            Assert.That(EmailValidator.ValidateEmail(email), Is.False);
        }
    }
    
    // [Test]
    // public
}