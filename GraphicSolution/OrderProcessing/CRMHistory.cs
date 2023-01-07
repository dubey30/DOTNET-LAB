namespace OrderProcessing;
public class CRMHistory:IOrderDetails,ICustomerDetails
{
public void ShowOrderDetails()
{
    Console.WriteLine("showing customer order Details");
}
public void ShowCustomerDetails()
{
    Console.WriteLine("Showing customer profile Details");
}
public void ChangeProfile()
{
    Console.WriteLine("Your customer profile has been Updated");
}
 void ICustomerDetails.showDetails()
{
    Console.WriteLine("Customer Personalized Information");
}
void  IOrderDetails.showDetails()
{
    Console.WriteLine("Customers Review Details");
}

}