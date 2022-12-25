


using DomainLayer.Models;
using ServiceLayer.Services;



Customer customer = new Customer();

static Customer[] GetCustomers()
{
    Customer customer1 = new Customer();

    customer1.Id = 12345;
    customer1.Name = "Gunel";
    customer1.Surname = "Celilova";
    customer1.Age = 26;
    customer1.Position = "Bank teller";


    Customer customer2 = new Customer();

    customer2.Id = 67890;
    customer2.Name = "Zeynbeb";
    customer2.Surname = "Kerimova";
    customer2.Age = 29;
    customer2.Position = "Managing Director";

    Customer customer3 = new Customer();

    customer3.Id = 37720;
    customer3.Name = "Yusif";
    customer3.Surname = "Celilov";
    customer3.Age = 24;
    customer3.Position = "Trainee";

    Customer customer4 = new Customer();

    customer4.Id = 55380; ;
    customer4.Name = "Rehim";
    customer4.Surname = "Selimov";
    customer4.Age = 23;
    customer4.Position = "Driver";

    Customer customer5 = new Customer();

    customer5.Id = 45800;
    customer5.Name = "Selale";
    customer5.Surname = "Abdullayeva";
    customer5.Age = 27;
    customer5.Position = "Credit Analyst";

    Customer[] arr = { customer1, customer2, customer3, customer4, customer5 };
    return arr;
}

var arr = GetCustomers();
CustomerService customerService= new CustomerService();
Console.WriteLine(customerService.GetCustomerMiddleAge(arr));
Console.WriteLine(customerService.GetCustomerAge(arr));