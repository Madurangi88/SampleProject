using System.Collections.Generic;

namespace Test.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }


        private ICollection<Destination> _destinations;
        public virtual ICollection<Destination> Destinations
        {
            get { return _destinations ?? (_destinations = new List<Destination>()); }
            protected set { _destinations = value; }
        }
    }
}
