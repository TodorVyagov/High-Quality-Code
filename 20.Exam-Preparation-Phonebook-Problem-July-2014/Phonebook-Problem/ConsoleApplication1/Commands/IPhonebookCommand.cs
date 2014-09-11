namespace Phonebook.Commands
{
    using System.Collections.Generic;

    public interface IPhonebookCommand
    {
        void Execute(IList<string> arguments, IPhonebookRepository repository);
    }
}
