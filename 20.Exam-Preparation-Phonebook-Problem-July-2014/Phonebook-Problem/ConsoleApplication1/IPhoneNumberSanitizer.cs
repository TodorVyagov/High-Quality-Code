namespace Phonebook
{
    public interface IPhoneNumberSanitizer
    {
        string ConvertPhoneToCanonical(string phoneNumber);
    }
}
