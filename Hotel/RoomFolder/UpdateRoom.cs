using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.RoomFolder
{
    public class UpdateRoom : ICrudRoom
    {
        
        public void Run(ApplicationDbContext dbContext)
        {
            Console.Clear();
            Console.WriteLine("Update a room");
            Console.WriteLine("=====================");

            foreach (var room in dbContext.Rooms)
            {
                Console.WriteLine($"Id: {room.RoomId}");
                Console.WriteLine($"Description: {room.Description}");
                Console.WriteLine($"Type: {room.Type}");
                Console.WriteLine($"Extra bed: {room.ExtraBed}");
                Console.WriteLine("====================");
            }

            Console.WriteLine("Choose the ID room you want to uppdate: ");
            var roomIdToUpdate = Console.ReadLine();
            var roomToUpdate = dbContext.Rooms.First(p => p.RoomId == roomIdToUpdate);
            Console.Clear();

            Console.Clear();
            Console.WriteLine("Wish room Type!");
            Console.WriteLine("1: Twin 24 square meter");
            Console.WriteLine("2: Triple 32 square meter");

            var typ = Console.ReadLine();
            var twin = "Twin";
            var triple = "Triple";
           

            if (typ == "1")
            {
                typ = twin;
            }
            else if (typ == "2")
            {
                typ = triple;
            }
            
            Console.Clear();
            Console.WriteLine("Wish your descraption?");
            Console.WriteLine("1: Singelroom");
            Console.WriteLine("2: Doubleroom");
            var descraption = Console.ReadLine();
            string s = "1: Singelroom";
            string b = "2: Doubleroom";

            if (descraption == "1")
            {
                descraption = s;
            }
            else if (descraption == "2")
            {
                descraption = b;
            }

            Console.Clear();
            Console.WriteLine("Do you wish a extra bed?");
            Console.WriteLine("1: YES");
            Console.WriteLine("2: NO");
            var extrabed = Console.ReadLine();
            var y = "YES";
            var n = "NO";
            if (extrabed == "1")
            {
                extrabed = y;
            }
            else if(extrabed == "2")
            {
                extrabed = n;
            }

            var rom = dbContext.Rooms.First(u => u.RoomId == roomIdToUpdate);
            roomToUpdate.Description = descraption;
            roomToUpdate.Type = typ;
            roomToUpdate.ExtraBed = extrabed;
            dbContext.SaveChanges();
            foreach (var room in dbContext.Rooms)
            {
                Console.WriteLine($"Id: {room.RoomId}");
                Console.WriteLine($"Description: {room.Description}");
                Console.WriteLine($"Type: {room.Type}");
                Console.WriteLine($"Extra bed: {room.ExtraBed}");
                Console.WriteLine("====================");
            }
        }
    }
}