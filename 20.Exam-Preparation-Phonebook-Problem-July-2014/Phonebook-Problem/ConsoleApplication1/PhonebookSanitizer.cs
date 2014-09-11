namespace Phonebook
{
    using System.Text;

    public class PhonebookSanitizer : IPhoneNumberSanitizer
    {
        private const string DefaultCountryCode = "+359";

        public string ConvertPhoneToCanonical(string phoneNumber)
        {
            var result = new StringBuilder();
            foreach (char symbol in phoneNumber)
            {
                if (char.IsDigit(symbol) || (symbol == '+'))
                {
                    result.Append(symbol);
                }
            }

            if (result.Length >= 2 && result[0] == '0' && result[1] == '0')
            {
                result.Remove(0, 1);
                result[0] = '+';
            }

            while (result.Length > 0 && result[0] == '0')
            {
                result.Remove(0, 1);
            }

            if (result.Length > 0 && result[0] != '+')
            {
                result.Insert(0, DefaultCountryCode);
            }

            return result.ToString();
        }
    }
}
