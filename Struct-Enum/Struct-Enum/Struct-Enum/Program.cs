
using Struct_Enum;
using Struct_Enum.Constans;
using Struct_Enum.Helpers.Enums;

//Test test= new Test();
////test.Number= 1;
////Console.WriteLine(test.Number);

//Employee employee = new Employee("Roya", "Meherremova", "Sumqayit", 26);


//Console.WriteLine(GetEmployee(employee));
//static Employee GetEmployee(Employee text)
//{
//    return text;
////}

//string email = "@ttgmail";
//if (email !="@ffgmail")
//{
//    Console.WriteLine(Errors.LoginMesage);
//}

int roleId = 2;

switch(roleId)
{
    case (int)Roles.SuperAdmin:
      Console.WriteLine( "Super Admindir");
        break;
    case (int)Roles.Admin:
        Console.WriteLine("Admindir");
        break;
    case (int)Roles.Member:
        Console.WriteLine("Memberdir");
        break;
       default:
        break;

}

string[]names=Enum.GetNames(typeof(Roles));
string role = "Admin";
foreach (var item in names)
{
    if (item==role)
    {
        Console.WriteLine($"User role is-{item}");
        break; 
    }
}

int[] nums = (int[])Enum.GetValues(typeof(Roles));
foreach (var item in nums)
{
    Console.WriteLine(item);
}