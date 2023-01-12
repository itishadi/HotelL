
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
            Console.WriteLine("DELETE en befintlig guest");
            Console.WriteLine("=====================");
            foreach (var g in dbContext.Guests)
            {
                Console.WriteLine($"GuestId: {g.GuestId}");
                Console.WriteLine($"Namn: {g.Name}");
                Console.WriteLine($"Age: {g.Age}");
                Console.WriteLine("====================");
            }

            Console.WriteLine("Välj Id på den guest som du vill radera");
            var guestIdToDelete = Console.ReadLine();
            var guestToDelete = dbContext.Guests.First(g => g.GuestId == guestIdToDelete);
            dbContext.Guests.Remove(guestToDelete);
            dbContext.SaveChanges();

            Console.Clear();
            foreach (var g in dbContext.Guests)
            {
                Console.WriteLine($"GuestId: {g.GuestId}");
                Console.WriteLine($"Namn: {g.Name}");
                Console.WriteLine($"Age: {g.Age}");
                Console.WriteLine("====================");
            }

            Console.WriteLine("\n Press any key to continue");
            Console.ReadLine();
        }
    }
}
