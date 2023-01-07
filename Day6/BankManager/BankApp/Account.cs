namespace Banking;
using BankManager;
public class Account
{
    public event BankOperation underBalance;
    public double Balance {get;set;}
    public Account (double amount)
    {
        this.Balance=amount;
    }
    public void Deposit(double amount)
    {
        this.Balance+=amount;
    }
    public void Withdraw(double amount)
    {
        this.Balance-=amount;
    }
    public override string ToString()
    {
        return base.ToString() + "current Balance="+this.Balance;
    }
    public void checkUnderBalance()
    {
        if(this.Balance<=5000)
        {
            Console.WriteLine("under Balance");
            underBalance(this.Balance);
        }
    }
}