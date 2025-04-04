using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace UserDetail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList userData = new ArrayList();

            Console.WriteLine("What is your name? (or type 'exit' to quit):");
            string userName = Console.ReadLine();
            if (userName.Trim().ToLower() == "exit") return;

            Console.WriteLine($"{userName}, please enter your surname:");
            string surname = Console.ReadLine();

            Console.WriteLine($"{userName}, please enter your age:");
            if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
            {
                Console.WriteLine("Invalid age. Please restart and enter a valid number.");
                return;
            }

            // Save user information
            userData.Add(new UserInfo(userName, surname, age));
            Console.WriteLine($"Thank you, {userName}! Your details have been saved.\n");

            // Display saved user data
            DisplayUserData(userData);
        }

        static void DisplayUserData(ArrayList userData)
        {
            Console.WriteLine("User Data:");
            foreach (UserInfo user in userData)
            {
                Console.WriteLine($"Name: {user.Name}, Surname: {user.Surname}, Age: {user.Age}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    public class UserInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public UserInfo(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
