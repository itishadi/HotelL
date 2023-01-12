using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.RoomFolder
{
    public class DeleteRoom : ICrudRoom
    {
        public void Run(ApplicationDbContext dbContext)
        {
            Console.WriteLine("DELETE en befintlig room");
            Console.WriteLine("=====================");

            foreach (var room in dbContext.Rooms)
            {
                Console.WriteLine($"Id: {room.RoomId}");
                Console.WriteLine($"Namn: {room.Description}");
                Console.WriteLine($"Size: {room.Type}");
                Console.WriteLine($"Extra bed: {room.ExtraBed}");
                Console.WriteLine("====================");
            }
            Console.WriteLine("Välj Id på den room som du vill radera");
            var roomIdToDelete = Console.ReadLine();

            var roomToDelete = dbContext.Rooms.First(p => p.RoomId == roomIdToDelete);
            dbContext.Rooms.Remove(roomToDelete);
            dbContext.SaveChanges();

            Console.WriteLine("\n Press any key to continue");
            Console.ReadLine();
        }
    }
}
