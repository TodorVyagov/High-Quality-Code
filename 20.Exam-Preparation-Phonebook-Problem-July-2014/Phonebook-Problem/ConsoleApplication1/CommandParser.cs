using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class CommandParser
    {
        public CommandInfo Parse(string text) 
        {
            int indexOfLeftParenthesis = text.IndexOf('(');
            
            if (indexOfLeftParenthesis == -1)
            {
                throw new ArgumentException("Invalid user command");
            }

            if (!text.EndsWith(")"))
            {
                throw new ArgumentException("Invalid user command");
            }

            string commandString = text.Substring(0, indexOfLeftParenthesis);
            string argumentsAsString = text.Substring(indexOfLeftParenthesis + 1, text.Length - indexOfLeftParenthesis - 2);
            string[] arguments = argumentsAsString.Split(',');
            for (int j = 0; j < arguments.Length; j++)
            {
                arguments[j] = arguments[j].Trim();
            }


            CommandInfo info = new CommandInfo();
            info.CommandString = commandString;
            info.Arguments = arguments.ToList<string>();
            return info;
        }
    }
}
