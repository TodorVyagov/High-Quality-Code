namespace Phonebook
{
    using System.Collections;

    public class CommandInfo
    {
        public string CommandString { get; set; }

        public IList Arguments { get; set; }
    }
}
