using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string reverseUserName = string.Empty;
            int failAttempts = 0;           

            for (int i = username.Length - 1; i >= 0; i--)
            {
                reverseUserName += username[i];
            }
            while (true)
            {                    
                string password = Console.ReadLine();                          
                if (reverseUserName == password)                                      
                {                                                              
                    Console.WriteLine($"User {username} logged in.");          
                    break;                                                     
                }                                                              
            
                else
                {
                    failAttempts++;
            
                    if (failAttempts > 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }

                //string password = Console.ReadLine();
                //string expectedPass = string.Empty;
                //
                //for (int i = password.Length - 1; i >= 0; i--)
                //{
                //    var leter = password[i];
                //    expectedPass += leter;
                //}
                //Console.WriteLine(expectedPass);
            }
        }
    }
}
