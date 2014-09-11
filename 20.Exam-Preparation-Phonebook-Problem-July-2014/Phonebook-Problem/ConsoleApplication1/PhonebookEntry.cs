namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PhonebookEntry : IComparable<PhonebookEntry>
    {
        private string name;

        private string nameToLowerCase;

        private SortedSet<string> phoneNumbers;

        public PhonebookEntry(string name)
        {
            this.Name = name;
            this.phoneNumbers = new SortedSet<string>();
        }

        public PhonebookEntry(string name, IEnumerable<string> phoneNumbers) : this(name)
        {
            this.phoneNumbers.UnionWith(phoneNumbers);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
                this.nameToLowerCase = value.ToLowerInvariant();
            }
        }

        //public IEnumerable<string> PhoneNumbers
        //{
        //    get
        //    {
        //        return new SortedSet<string>(this.phoneNumbers);
        //    }
        //}

        public void Add(string newPhoneNumber)
        {
            this.phoneNumbers.Add(newPhoneNumber);
        }

        public void Remove(string phoneNumber)
        {
            this.phoneNumbers.Remove(phoneNumber);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append('[');
            result.Append(this.Name);
            string phoneNumbersAsString = string.Join(", ", this.phoneNumbers);
            result.Append(phoneNumbersAsString);
            result.Append(']');
            
            return result.ToString();
        }

        public int CompareTo(PhonebookEntry other)
        {
            return this.nameToLowerCase.CompareTo(other.nameToLowerCase);
        }
    }
}
