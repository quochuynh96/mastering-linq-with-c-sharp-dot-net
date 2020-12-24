namespace MasteringLINQ
{
    public class Email
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public Email(string name, string emailAddress)
        {
            Name = name;
            EmailAddress = emailAddress;
        }
    }
}
