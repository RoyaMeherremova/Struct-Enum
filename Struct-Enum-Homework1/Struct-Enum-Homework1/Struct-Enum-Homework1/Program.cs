
using Service.Services;

Account account = new Account();
//Console.WriteLine(account.Login("test@code.edu.az", "test12345", 1));

Console.WriteLine("Add Email:");
string email = Console.ReadLine();
Console.WriteLine("Add Password:");
string password = Console.ReadLine();
Console.WriteLine("Add Role:");
int roles = int.Parse(Console.ReadLine());
Console.WriteLine(account.Login(email, password, roles));