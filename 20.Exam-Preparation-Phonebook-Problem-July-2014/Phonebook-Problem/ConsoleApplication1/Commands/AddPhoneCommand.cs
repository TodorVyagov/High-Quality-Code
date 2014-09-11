namespace Phonebook.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AddPhoneCommand : IPhonebookCommand
    {
        private IPhoneNumberSanitizer sanitizer = new PhonebookSanitizer();

        public void Execute(IList<string> arguments, IPhonebookRepository repository)
        {
            if (arguments.Count < 2)
            {
                throw new ArgumentException("Invalid number of arguments to add phone number");
            }

            string name = arguments[0];
            var phoneNumbers = arguments.Skip(1).ToList();
            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                phoneNumbers[i] = sanitizer.ConvertPhoneToCanonical(phoneNumbers[i]);
            }

            bool isPhoneNew = repository.AddPhone(name, phoneNumbers);

            if (isPhoneNew)
            {
                Print("Phone entry created");
            }
            else
            {
                Print("Phone entry merged");
            }
        }
    }
}
