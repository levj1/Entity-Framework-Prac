using Data.Access;
using Domain.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // database initialization work
            Database.SetInitializer(new NullDatabaseInitializer<ContactContext>());
            


            Console.ReadLine();
        }

        private static void InsertContact()
        {
            var contact = new Contact
            {
                
            };
        }

        private static void InsertAddress()
        {
            var address = new Address
            {
                AddressLine1 = "234 Orange Rd",
                AddressLine2 = "apt #1a",
                City = "Citywide",
                State = "DC",
                ZipCode = "12354"
            };

            var address1 = new Address
            {
                AddressLine1 = "54th Rd",
                City = "Easwood",
                State = "MD",
                ZipCode = "54321"
            };

            using (var context = new ContactContext())
            {
                context.Database.Log = Console.WriteLine;
                // use Add for one and AddRange for a list
                context.Addresses.AddRange(new List<Address> { address, address1 });
                context.SaveChanges();
            }
        }
    }
}
