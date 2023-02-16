using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace LoginTest
{
    internal class ElectroLoginIPC
    {
        public class User
        {
            public string Username { get; }
            public int Password { get; }

            public User(string username, int password)
            {
                this.Username = username;
                this.Password = password;
            }
        }

        private static readonly User[] Users = new User[]
        {
            new User("Carlos", 12345),
            new User("3S", 1234),
            new User("Peter", 4321)
        };

        private static void Main(string[] args)
        {
            // Start the IPC process
            var ipcProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "npm",
                    Arguments = "run ipc",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            ipcProcess.Start();

            Console.WriteLine("Enter 1 to login");
            var input = Console.ReadLine();

            while (input != "1")
            {
                Console.WriteLine("Wrong number, input 1 to log in: ");
                input = Console.ReadLine();
            }

            while (true)
            {
                Console.WriteLine("Write your username:");
                var username = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                var password = Console.ReadLine();

                if (int.TryParse(password, out int passwordValue)
                    && Users.Any(user => username == user.Username && passwordValue == user.Password))
                {
                    Console.WriteLine("You have successfully logged in !!!");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine("Your username or password is incorrect, try again !!!");
            }
        }
    }
}