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
            Console.WriteLine("UPDATE en befintlig guest");
            Console.WriteLine("=====================");

           
            foreach (var g in dbContext.Guests)
            {
                Console.WriteLine($"GuestId: {g.GuestId}");
                Console.WriteLine($"Namn: {g.Name}");
                Console.WriteLine($"Age: {g.Age}");
                Console.WriteLine("====================");
            }

            Console.WriteLine("Välj Id/GuestID på den guest som du vill uppdatera");
            var guestIdToUpdate = Console.ReadLine();
            var guestToUpdate = dbContext.Guests.First(g => g.GuestId == guestIdToUpdate);

            Console.Clear();
            Console.WriteLine("Ange Name: ");
            var nameUpdate = Console.ReadLine();
           
            Console.Clear();
            Console.WriteLine("Ange age: ");
            var ageUpdate = Convert.ToInt32(Console.ReadLine());

            guestToUpdate.Name = nameUpdate;
            guestToUpdate.Age = ageUpdate;

            dbContext.SaveChanges();
            foreach (var g in dbContext.Guests)
            {
                Console.WriteLine($"{g.GuestId} - {g.Name} - {g.Age}");
            }
            var guestsUpdate = dbContext.Guests.First(g => g.GuestId == guestIdToUpdate);
        }
    }
}
