namespace UserManagementApp
{
    internal class Program
    {
        static bool stopLoop = false;
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            User userManager = new User();

            while (true)
            {
                Console.WriteLine("\n******************** User Management System ********************");
                Console.WriteLine("1- Add User");
                Console.WriteLine("2- Update User");
                Console.WriteLine("3- Delete User");
                Console.WriteLine("4- Print All Users");
                Console.WriteLine("5- Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        userManager.AddUser(users);
                        break;
                    case 2:
                        userManager.UpdateUser(users);
                        break;
                    case 3:
                        userManager.DeleteUser(users);
                        break;
                    case 4:
                        userManager.PrintAllUsers(users);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                TryAgain();
                if (stopLoop)
                {
                    break;
                }
            }

        }

        static void TryAgain()
        {
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Do you want to try anything else? \n Y for yes || N for no");
            char tryAgain = char.Parse(Console.ReadLine());
            if (tryAgain == 'Y' || tryAgain == 'y')
            {
                Console.WriteLine("*****************************************************************");
            }
            else if (tryAgain == 'N' || tryAgain == 'n')
            {
                stopLoop = true;
            }
        }
    }
}

    




