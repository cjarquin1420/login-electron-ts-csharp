using static LoginTest.ElectroLoginIPC;

var arrUsers = new User[]
{
    new User("Carlos", 12345),
    new User("3S", 1234),
    new User("Peter", 4321)
};

//Start:
Console.WriteLine("Enter 1 to login");
var input = Console.ReadLine();

while (input != "1")
{
    Console.WriteLine("Wrong number, input 1 to log in: ");
    input = Console.ReadLine();
}

bool successful = false;
while (!successful)
{
    Console.WriteLine("Write your username:");
    var username = Console.ReadLine();

    User selectedUser = null;
    foreach (var user in arrUsers)
    {
        if (username == user.username)
        {
            selectedUser = user;
            break;
        }
    }

    if (selectedUser == null)
    {
        Console.WriteLine("Wrong username, try again!");
        continue;
    }

    Console.WriteLine("Enter your password:");
    var passwordInput = Console.ReadLine();
    if (!int.TryParse(passwordInput, out int password))
    {
        Console.WriteLine("Password must be a number, try again!");
        continue;
    }

    if (selectedUser.password == password)
    {
        Console.WriteLine("You have successfully logged in !!!");
        Console.ReadLine();
        successful = true;
    }
    else
    {
        Console.WriteLine("Your username or password is incorrect, try again !!!");
    }
}

    //else if (input == "2")
    //{

    //    Console.WriteLine("Enter your username:");
    //    var username = Console.ReadLine();

    //    Console.WriteLine("Enter your password:");
    //    var password = Console.ReadLine();

    //    Array.Resize(ref arrUsers, arrUsers.Length + 1);
    //    arrUsers[arrUsers.Length - 1] = new Users(username, int.Parse(password));
    //    successfull = true;
    //    goto Start;

    ////}
    //else
    //{
    //    Console.WriteLine("Try again !!!");
    //    break;


    //}

public class User
{
    public string username;
    public int password;

    public User(string username, int password)
    {
        this.username = username;
        this.password = password;
    }
}