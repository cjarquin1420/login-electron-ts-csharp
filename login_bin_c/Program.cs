
var arrUsers = new User[]
{
    new User("Carlos", 12345),
    new User("3S", 1234),
    new User("Peter", 4321)
};


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