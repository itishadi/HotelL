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
            Console.WriteLine("READ alla personer");
            Console.WriteLine("=====================");

            Console.WriteLine("Rooms order by RoomNumber");
            Console.WriteLine("====================\n");
            foreach (var room in dbContext.Rooms)
            {
                Console.WriteLine($"Id: {room.RoomId}");
                Console.WriteLine($"Namn: {room.Description}");
                Console.WriteLine($"Size: {room.Type}");
                Console.WriteLine($"Extra bed: {room.ExtraBed}");
                Console.WriteLine("====================");
            }
            Console.WriteLine("\n Press any key to continue");
            Console.ReadLine();
        }
    }
}
