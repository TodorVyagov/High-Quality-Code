namespace Phonebook.Commands
{
    using System;
    using System.Collections.Generic;

    public class PhonebookCommandsFactory
    {
        private IDictionary<string, IPhonebookCommand> commands;

        public PhonebookCommandsFactory()
        {
            this.commands = new Dictionary<string, IPhonebookCommand>();
        }

        public IPhonebookCommand GetCommand(string commandString)
        {
            if (!this.commands.ContainsKey(commandString))
            {
                IPhonebookCommand command;
                switch (commandString)
                {
                    case "AddPhone": command = new AddPhoneCommand(); break;
                    case "ChangePhone": command = new ChangePhoneCommand(); break;
                    case "List": command = new ListPhonesCommand(); break;
                    case "Remove": command = new RemovePhoneCommand(); break;
                    default: throw new ArgumentException("Invalid command name");
                }

                this.commands.Add(commandString, command);
            }

            return this.commands[commandString];
        }
    }
}
