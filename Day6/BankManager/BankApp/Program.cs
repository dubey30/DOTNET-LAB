using Banking;
using BankManager;

BankMangt validate = new BankMangt();
BankOperation validateAcc = new BankOperation(validate.BlockAccount);
BankOperation validateSms = new BankOperation(validate.SendSMS);
BankOperation validateEmail = new BankOperation(validate.SendEmail);

Account acct = new Account(6000);
acct.underBalance+=validateAcc;
acct.underBalance+=validateSms;
acct.underBalance+=validateEmail;

Console.WriteLine("Enter amount to be withdrawn");
double amount = double.Parse(Console.ReadLine());
acct.Withdraw(amount);

Console.WriteLine("Amount Before WithDraw");
Console.WriteLine(acct);

acct.checkUnderBalance();
Console.WriteLine("Amount After WithDraw");
Console.WriteLine(acct);