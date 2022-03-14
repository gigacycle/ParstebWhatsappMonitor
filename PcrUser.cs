using System;

namespace ParstebWhatsapp
{
    public class PcrUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime LastActivityTimeStamp { get; set; }
        public int IncorrectPasswordAttempts { get; set; }

        public string GetDecryptedPassword()
        {
            return SecureText.Decrypt(Password);
        }

        public PcrUser(int id, string username, string password, int userType, string name, string lastName, DateTime lastActivityTimeStamp, int incorrectPasswordAttempts)
        {
            Id = id;
            Username = username;
            Password = password;
            UserType = userType;
            Name = name;
            LastName = lastName;
            LastActivityTimeStamp = lastActivityTimeStamp;
            IncorrectPasswordAttempts = incorrectPasswordAttempts;
        }

        public bool Authenticate(string username, string password)
        {
            bool rv = false;
            if (Username.ToLower() == username.ToLower() && SecureText.Decrypt(Password) == password)
                rv = true;
            return rv;
        }

        public override string ToString()
        {
            return Username + " - " + Name + " " + LastName;
        }
    }
}
