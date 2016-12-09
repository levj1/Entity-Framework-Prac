using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }

        public Contact() { }
        public Contact(int id, string firstname, string lastname, Address address)
        {

        }
        public Contact(string firstname, string lastname, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
        }
    }
}
