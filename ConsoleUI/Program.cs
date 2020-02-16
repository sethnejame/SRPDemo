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
               AccountGenerator.CreateAccount(user);
               StandardMessages.EndApplication();
            }
            else
            {
                StandardMessages.EndApplication();
            }
        }
    }
}
