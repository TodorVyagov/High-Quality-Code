namespace Phonebook.Commands
{
    using System;
    using System.Collections.Generic;

    public class ChangePhoneCommand : IPhonebookCommand
    {
        private IPhoneNumberSanitizer sanitizer = new PhonebookSanitizer();

        public void Execute(IList<string> arguments, IPhonebookRepository repository)
        {
            if ((arguments.Count != 2))
            {
                throw new ArgumentException("Invalid number of arguments to change phone number");
            }

            string oldPhoneNumber = sanitizer.ConvertPhoneToCanonical(arguments[0]);
            string newPhoneNumber = sanitizer.ConvertPhoneToCanonical(arguments[1]);
            int changedPhoneNumbersCount = repository.ChangePhone(oldPhoneNumber, newPhoneNumber);
            Print(changedPhoneNumbersCount + " numbers changed");
        }
    }
}
