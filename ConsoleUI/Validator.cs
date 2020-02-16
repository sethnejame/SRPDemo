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
                StandardMessages.DisplayValidationError("first name");
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError("last name");                return false;
            }

            return true;
        }
    }
}