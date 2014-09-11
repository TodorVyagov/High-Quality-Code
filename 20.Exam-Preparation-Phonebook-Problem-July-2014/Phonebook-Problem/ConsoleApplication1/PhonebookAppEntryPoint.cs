namespace Phonebook
{
    using System;
    using System.Linq;
    using System.Text;
    
    using Phonebook.Commands;

    public class PhonebookAppEntryPoint
    {
        public static void Main()
        {
            var commandsFactory = new PhonebookCommandsFactory();
            IPhonebookRepository repository = new PhonebookRepositoryWithDictionary();
            var parser = new CommandParser();

            // TODO: To extract Print class
            StringBuilder input = new StringBuilder();

            while (true)
            {
                string currentLine = Console.ReadLine();
                currentLine = currentLine.Trim();
                if (currentLine == "End" || currentLine == null)
                {
                    break;
                }

                var commandInfo = parser.Parse(currentLine);

                IPhonebookCommand command = commandsFactory.GetCommand(commandInfo.CommandString);
                command.Execute(commandInfo.Arguments, repository);
            }

            Console.Write(input);
        }
            
        private void Print(string text)
        {
            input.AppendLine(text);
        }
    }
}