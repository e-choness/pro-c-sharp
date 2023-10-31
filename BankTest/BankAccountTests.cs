using BankLibrary;
using NuGet.Frameworks;

namespace BankTest;

public class BankAccountTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Debit_WithValidAmount_UpdatesBalance()
    {
        double beginningBalance = 11.99;
        double debitAmount = 4.55;
        double expected = 7.44;

        var account = new BankAccount("Mr. Bryan Walton", beginningBalance);
        account.Debit(debitAmount);

        double actual = account.Balance;
        Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
    }

    [Test]
    public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
    {
        // Arrange
        double beginningBalance = 11.99;
        double debitAmount = -100.00;

        var account = new BankAccount("Mr. Bryan Walton", beginningBalance);

        try
        {
            account.Debit(debitAmount);
        }
        catch (ArgumentOutOfRangeException e)
        {
            StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
            return;
        }
        
        Assert.Fail("The expected exception was not thrown.");
    }
}