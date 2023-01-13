
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.GuestFolder
{
    public class DeleteGuest : ICrudGuest
    {
        public void Run(ApplicationDbContext dbContext)
        {
            Console.Clear();
            Console.WriteLine("Delete a guest");
            Console.WriteLine("=====================");
            foreach (var g in dbContext.Guests)
            {
                Console.WriteLine($"ID: {g.GuestId}");
                Console.WriteLine($"Namn: {g.Name}");
                Console.WriteLine($"Age: {g.Age}");
                Console.WriteLine("====================");
            }

            Console.WriteLine("Choose a ID you want to delete: ");
            var guestIdToDelete = Console.ReadLine();
            var guestToDelete = dbContext.Guests.First(g => g.GuestId == guestIdToDelete);
            dbContext.Guests.Remove(guestToDelete);
            dbContext.SaveChanges();

            Console.Clear();
            foreach (var g in dbContext.Guests)
            {
                Console.WriteLine($"ID: {g.GuestId}");
                Console.WriteLine($"Namn: {g.Name}");
                Console.WriteLine($"Age: {g.Age}");
                Console.WriteLine("====================");
            }

            Console.WriteLine("\n Press any key to continue");
            Console.ReadLine();
        }
    }
}
