namespace Phonebook.Commands
{
    using System;
    using System.Collections.Generic;

    class RemovePhoneCommand : IPhonebookCommand
    {
        public void Execute(IList<string> arguments, IPhonebookRepository repository)
        {
            throw new NotImplementedException();
        }
    }
}
