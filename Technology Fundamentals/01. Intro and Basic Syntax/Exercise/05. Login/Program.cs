using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string currentPassword = Console.ReadLine();
            int counter = 0;
            while (currentPassword != password)
            {
                counter += 1;
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!"); return;
                }
                currentPassword = Console.ReadLine();

                Console.WriteLine("Incorrect password. Try again.");
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
