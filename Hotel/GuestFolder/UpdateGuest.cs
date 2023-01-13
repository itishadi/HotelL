using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.GuestFolder
{
    public class UpdateGuest : ICrudGuest
    {
        public void Run(ApplicationDbContext dbContext)
        {
            Console.WriteLine("Update a guest");
            Console.WriteLine("=====================");

           
            foreach (var g in dbContext.Guests)
            {
                Console.WriteLine($"ID: {g.GuestId}");
                Console.WriteLine($"Namn: {g.Name}");
                Console.WriteLine($"Age: {g.Age}");
                Console.WriteLine("====================");
            }

            Console.WriteLine("Choose a ID you want to update: ");
            var guestIdToUpdate = Console.ReadLine();
            var guestToUpdate = dbContext.Guests.First(g => g.GuestId == guestIdToUpdate);

            Console.Clear();
            Console.WriteLine("Enter new Name: ");
            var nameUpdate = Console.ReadLine();
           
            Console.Clear();
            Console.WriteLine("Enter new age: ");
            var ageUpdate = Convert.ToInt32(Console.ReadLine());

            guestToUpdate.Name = nameUpdate;
            guestToUpdate.Age = ageUpdate;

            dbContext.SaveChanges();
            foreach (var g in dbContext.Guests)
            {
                Console.WriteLine($"ID: {g.GuestId}");
                Console.WriteLine($"Namn: {g.Name}");
                Console.WriteLine($"Age: {g.Age}");
                Console.WriteLine("====================");
            }
            var guestsUpdate = dbContext.Guests.First(g => g.GuestId == guestIdToUpdate);
        }
    }
}
