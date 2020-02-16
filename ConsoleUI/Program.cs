using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            var user = PersonDataCapture.CaptureUserInfo();

            if (Validator.Validate(user))
            {
                Console.WriteLine($"Your username is " +
                                  $"{ user.FirstName.Substring(0,1) }" +
                                  $"{ user.LastName}");
            }
            
            StandardMessages.EndApplication();
        }
    }
}
