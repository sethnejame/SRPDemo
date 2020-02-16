using System;

namespace ConsoleUI
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }
            
        public static void EndApplication()
        {
            Console.ReadLine();
        }
        
        public static void FirstName()
        {
            Console.WriteLine("What's your first name?");
        }
        
        public static void LastName()
        {
            Console.WriteLine("What's your last name?");
        }
    }
}