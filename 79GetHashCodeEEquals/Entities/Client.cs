namespace _79GetHashCodeEEquals.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Client(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            if (obj is not Client)
            {
                throw new ArgumentException("The type is wrong");
            }

            Client other = obj as Client;

            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
