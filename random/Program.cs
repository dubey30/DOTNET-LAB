// See https://aka.ms/new-console-template for more information
using Banking;
using Maths;
Account acc123 = new Account();

acc123.Deposit(15000);
float currentBalance123=acc123.GetBalance();
Console.WriteLine("balance"+currentBalance123);
Account acc124=new Account();
acc124.Deposit(8000);
float  currentBalance124=acc124.GetBalance();
 
Complex  c1=new Complex(34,56);
Complex c2=new Complex(11,78);
Complex c3=c1 + c2;