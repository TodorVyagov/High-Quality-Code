namespace Phonebook.Commands
{
    using System;
    using System.Collections.Generic;
    
    public class ListPhonesCommand : IPhonebookCommand
    {
        public void Execute(IList<string> arguments, IPhonebookRepository repository)
        {
            try
            {
                IEnumerable<PhonebookEntry> entries = repository.ListEntries(int.Parse(arguments[0]), int.Parse(arguments[1]));
                foreach (var entry in entries)
                {
                    Print(entry.ToString());
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Print("Invalid range");
            }
        }
    }
}
