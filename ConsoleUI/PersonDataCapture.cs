using System;

namespace ConsoleUI
{
    public class PersonDataCapture
    {
        public static Person CaptureUserInfo()
        {
            Person output = new Person();
            
            StandardMessages.FirstName();
            output.FirstName = Console.ReadLine();
            
            StandardMessages.LastName();
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}