using System;
using Task_2.Classes;
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];
            users[0] = new User()
            {
                Id = 1,
                Username = "User1",
                Password = "pass1",
                Messages = new string[] { "Hello User1.", "How are you?"
                }
            };
            users[1] = new User()
            {
                Id = 2,
                Username = "User2",
                Password = "pass2",
                Messages = new string[] { "Hello User2.", "How are you?"
                }
            };
            users[2] = new User()
            {
                Id = 3,
                Username = "User3",
                Password = "pass3",
                Messages = new string[] { "Hello User3.", "How are you?"
                }
            };

            while (true)
            {
                Console.WriteLine("\nDo you want to: \n1.Login \n2.Register? \n3.Exit");
                string selected = Console.ReadLine();
                switch (selected)
                {
                    case "1":
                        LoginUser(users);
                        break;
                    case "2":
                        Register(users);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }

            static void LoginUser(User[] users)
            {
                Console.WriteLine("LOGIN\n");

                Console.WriteLine("Please enter your username:");
                string username = Console.ReadLine();

                Console.WriteLine("Please enter your password:");
                string password = Console.ReadLine();
                bool userFound = false;

                foreach (User user in users)
                {
                    if (user.Username == username && user.Password == password)
                    {
                        Console.WriteLine($"\nWelcome {user.Username}. Here are your messages:");
                        foreach (string message in user.Messages)
                        {
                            Console.WriteLine(message);
                        }
                        userFound = true;
                    }
                }
                if (!userFound)
                {
                    Console.WriteLine("USER NOT FOUND, TRY AGAIN");
                }
            }
            static void Register(User[] users)
            {
                Console.WriteLine("REGISTER");

                Console.WriteLine("Please enter ID:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a username");
                string username = Console.ReadLine();

                Console.WriteLine("Please enter a password");
                string password = Console.ReadLine();

                bool isRegistered = false;
                foreach (User user in users)
                {
                    if (user.Username == username)
                    {
                        Console.WriteLine("The username is already taken! ");
                        isRegistered = true;
                        break;
                    }
                    isRegistered = false;
                }
                if (!isRegistered)
                {
                    User newUser = new User()
                    {
                        Id = id,
                        Username = username,
                        Password = password,
                        Messages = new string[0]
                    };
                    Array.Resize(ref users, users.Length + 1);
                    users[users.Length - 1] = newUser;
                    Console.WriteLine("Registered Users:");
                    foreach (User u in users)
                    {
                        Console.WriteLine($"Id: {u.Id}, Username: {u.Username}");
                    }
                }
            }
        }
    }
}


