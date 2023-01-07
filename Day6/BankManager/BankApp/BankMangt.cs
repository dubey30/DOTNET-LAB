namespace BankManager;
public delegate void BankOperation(double amount);
public class BankMangt
{
public void BlockAccount(double amount)
{
    Console.WriteLine("Your Account is Blocked");
}
public void SendEmail(double amount)
{
    Console.WriteLine("Email is Send");
}
public void SendSMS(double amount)
{
    Console.WriteLine("sms is send");
}
}
