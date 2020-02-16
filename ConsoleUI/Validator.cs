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
                StandardMessages.DisplayValidationError(person.FirstName);
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError(person.LastName);                return false;
            }

            return true;
        }
    }
}