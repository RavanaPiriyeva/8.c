using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Istifadeci adini daxil edin :");
            string username = Console.ReadLine();

            Console.WriteLine("\nParolu daxil edin :");
            string password = Console.ReadLine();
            
            User user = new User(username)
            {
                Password = password
            };
            user.GetInfo();
        }
    }
}
