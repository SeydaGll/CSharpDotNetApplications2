namespace Phonebook
{
    public class Phones

    {
        
        public string AreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneType PhoneType { get; set; }
    }

    public enum PhoneType
    {
        GSM,
        FAX,
        Home,
        Work
    }
}