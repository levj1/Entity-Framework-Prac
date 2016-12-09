using Domain.Classes;
using System.Data.Entity;
namespace Data.Access
{
    public class ContactContext: DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
