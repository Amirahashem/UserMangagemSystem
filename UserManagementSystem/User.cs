using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementApp
{
    internal class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }

        public void AddUser(List<User> users)
        {
            Console.WriteLine("******************** Add User ********************");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            User newUser = new User
            {
                name = name,
                email = email,
                phoneNumber = phoneNumber
            };
            users.Add(newUser);

            Console.WriteLine("******************** User Information You Entered ********************");
            Console.WriteLine($"Name: {newUser.name}");
            Console.WriteLine($"Email: {newUser.email}");
            Console.WriteLine($"Phone Number: {newUser.phoneNumber}");
        }

        public void UpdateUser(List<User> users)
        {
            Console.WriteLine("******************** Update Data of User ********************");
            Console.Write("Enter User Phone Number you want to Edit: ");
            string phoneNumber = Console.ReadLine();
            User Foundeduser = users.FirstOrDefault(x => x.phoneNumber == phoneNumber);
            bool flag = false;

            if (Foundeduser != null)
            {
                Console.Write("1-Edit Name: \n2-Edit Email: \n3-Edit PhoneNumber: \n");
                int choseToEdit = int.Parse(Console.ReadLine());

                switch (choseToEdit)
                {
                    case 1:
                        Console.Write("Enter Edited Name: ");
                        Foundeduser.name = Console.ReadLine();
                        flag = true;
                        break;
                    case 2:
                        Console.Write("Enter Edited Email: ");
                        Foundeduser.email = Console.ReadLine();
                        flag = true;
                        break;
                    case 3:
                        Console.Write("Enter Edited Phone Number: ");
                        Foundeduser.phoneNumber = Console.ReadLine();
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Wrong Number Try Again From First");
                        break;
                }

                if (flag)
                {
                    Console.WriteLine("******************** New User Information You Edited ********************");
                    Console.WriteLine($"Name: {Foundeduser.name}");
                    Console.WriteLine($"Email: {Foundeduser.email}");
                    Console.WriteLine($"Phone Number: {Foundeduser.phoneNumber}");
                }
            }
            else
            {
                Console.WriteLine("No user Like this");
            }
        }

        public void DeleteUser(List<User> users)
        {
            Console.WriteLine("******************** Delete User ********************");
            Console.Write("Enter User Phone Number you want to Delete: ");
            string phoneNumber = Console.ReadLine();
            User Foundeduser = users.FirstOrDefault(x => x.phoneNumber == phoneNumber);

            if (Foundeduser != null)
            {
                users.Remove(Foundeduser);
                Console.WriteLine($"- YOU DELETE USER: {Foundeduser.name}.");
            }
            else
            {
                Console.WriteLine("No user Like this");
            }
        }

        public void PrintAllUsers(List<User> users)
        {
            if (users.Count == 0)
            {
                Console.WriteLine("===================================================================");
                Console.WriteLine("No users to print");
                return;
            }

            Console.WriteLine("******************** Print All Users ********************");
            int count = 1;

            foreach (var user in users)
            {
                Console.WriteLine($"User {count}");
                Console.WriteLine($"Name: {user.name}");
                Console.WriteLine($"Email: {user.email}");
                Console.WriteLine($"Phone Number: {user.phoneNumber}");
                count++;
                if (count <= users.Count)
                {
                    Console.WriteLine("----------------");
                }
            }
        }
    }

}
