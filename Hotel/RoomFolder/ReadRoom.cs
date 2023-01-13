using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.RoomFolder
{
    public class ReadRoom : ICrudRoom
    {
        public void Run(ApplicationDbContext dbContext)
        {
            Console.WriteLine("Read all rooms");
            Console.WriteLine("=====================\n");

            foreach (var room in dbContext.Rooms)
            {
                Console.WriteLine($"Id: {room.RoomId}");
                Console.WriteLine($"Description: {room.Description}");
                Console.WriteLine($"Type: {room.Type}");
                Console.WriteLine($"Extra bed: {room.ExtraBed}");
                Console.WriteLine("====================");
            }
            Console.WriteLine("\n Press any key to continue");
            Console.ReadLine();
        }
    }
}
