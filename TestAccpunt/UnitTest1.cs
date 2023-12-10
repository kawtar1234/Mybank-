using banking;

namespace TestAccpunt;

public class Tests
{
    [Test]
    public void NewAccountShouldHaveZeroBalance()
    {
        Account account = new Account("testAccount");
        Assert.AreEqual(0, account.getBalance());
    }

    [Test]
    public void NewAccountWithIntialBalance()
    {
        Account account = new Account("testAccount", 999);
        Assert.AreEqual(999, account.getBalance());
    }

    [Test]
    public void DepositeShouldIncreaseBalnce()
    {
        Account account = new Account("testAccount", 100);
        account.Deposite(88);
        Assert.AreEqual(188, account.getBalance());
    }

    [Test]
    public void DepositeNegativeValue()
    {
        Account account = new Account("testAccount", 100);
        account.Deposite(-88);
        Assert.AreEqual(100, account.getBalance());
    }

    [Test]
    public void WithdrawShouldDecreaseBalance()
    {
        Account account = new Account("testAccount", 100);
        account.Withdraw(20);
        Assert.AreEqual(80, account.getBalance());
    }

    [Test]
    public void WithdrawOutOfRangeBalance()
    {
        Account account = new Account("testAccount", 200);
        account.Withdraw(300);
        Assert.AreEqual(200, account.getBalance());
    }

    [Test]
    public void WithdrawNegativeValue()
    {
        Account account = new Account("testAccount", 200);
        account.Withdraw(-788);
        Assert.AreEqual(200, account.getBalance());
    }

    [Test]
    public void GetTheAccountName()
    {
        Account account = new Account("kawtar");
        StringAssert.Contains("kawtar", account.getAccountName());
    }
}
