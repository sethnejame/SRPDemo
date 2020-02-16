using System;
using Microsoft.Win32;

namespace ConsoleUI
{
    public class Validator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name!");
                StandardMessages.EndApplication();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                Console.WriteLine("You did not give us a valid last name!");
                StandardMessages.EndApplication();
                return false;
            }

            return true;
        }
    }
}