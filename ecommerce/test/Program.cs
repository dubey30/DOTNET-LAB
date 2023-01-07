// See https://aka.ms/new-console-template for more information
using membership;
using HR;

Console.WriteLine("TFL Store");
Console.WriteLine("****************");
Console.WriteLine("Enter your Email Id");
string email=Console.ReadLine();

Console.WriteLine("Enter your password");
string password=Console.ReadLine();

if(AuthManager.Validate(email,password)){
    Console.WriteLine("Welcome to Transflower Store");
    Employee emp=new SalesManager();
    emp.DoWork();
    Console.WriteLine(emp);
    float salary=emp.ComputePay();
    Console.WriteLine("salary="+salary);
}
   else{ 
    Console.WriteLine("Invalid User");

}
Console.WriteLine("Thank you for visiting transflower");
