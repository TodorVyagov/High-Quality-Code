namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class PhonebookRepositoryWithDictionary : IPhonebookRepository
    {
        private OrderedSet<PhonebookEntry> phoneEntries = new OrderedSet<PhonebookEntry>();
        private Dictionary<string, PhonebookEntry> phonebookByName = new Dictionary<string, PhonebookEntry>();
        private MultiDictionary<string, PhonebookEntry> phonebookByNumber = new MultiDictionary<string, PhonebookEntry>(false);

        public bool AddPhone(string name, IEnumerable<string> phoneNumbers)
        {
            string nameToLowerCase = name.ToLowerInvariant();
            PhonebookEntry phonebookEntry;
            bool flag = !this.phonebookByName.TryGetValue(nameToLowerCase, out phonebookEntry);
            if (flag)
            {
                phonebookEntry = new PhonebookEntry(name, phoneNumbers);
                this.phonebookByName.Add(nameToLowerCase, phonebookEntry);
                this.phoneEntries.Add(phonebookEntry);
            }

            foreach (var phoneNumber in phoneNumbers)
            {
                this.phonebookByNumber.Add(phoneNumber, phonebookEntry);
            }

            return flag;
        }

        public int ChangePhone(string oldPhoneNumber, string newPhoneNumber)
        {
            var entriesContainingNumber = this.phonebookByNumber[oldPhoneNumber].ToList();
            foreach (var phonebookEntry in entriesContainingNumber)
            {
                phonebookEntry.Remove(oldPhoneNumber);
                this.phonebookByNumber.Remove(oldPhoneNumber, phonebookEntry);
                phonebookEntry.Add(newPhoneNumber);
                this.phonebookByNumber.Add(newPhoneNumber, phonebookEntry);
            }

            return entriesContainingNumber.Count;
        }

        public PhonebookEntry[] ListEntries(int startIndex, int count)
        {
            if (startIndex < 0 || startIndex + count > this.phonebookByName.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid start index and/or count of ");
            }

            PhonebookEntry[] resultPhoneNumbers = new PhonebookEntry[count];

            for (int i = startIndex; i <= startIndex + count - 1; i++)
            {
                PhonebookEntry entry = this.phoneEntries[i];
                resultPhoneNumbers[i - startIndex] = entry;
            }

            return resultPhoneNumbers;
        }
    }
}
