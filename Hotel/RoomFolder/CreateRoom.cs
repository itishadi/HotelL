using Hotel.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.RoomFolder
{
    public class CreateRoom : ICrudRoom
    {
        public void Run(ApplicationDbContext dbContext)
        {
            Console.Clear();    
            Console.WriteLine("Create a RoomID!");
            var roomNumber = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Wish room size!");
            Console.WriteLine("1: Twin 24 square meter");
            Console.WriteLine("2: Triple 32 square meter");

            var typ = Console.ReadLine();
            var singleroom = "Twin";
            var doubleroom = "Triple";

            if (typ == "1")
            {
                typ = singleroom;
            }
            else if(typ == "2")
            {
                typ = doubleroom;
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
            else if (descraption== "2")
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
            else if (extrabed == "2")
            {
                extrabed = n;
            }

            Console.Clear();
            dbContext.Rooms.Add(new Room
            {
                RoomId = roomNumber,
                Description = descraption,
                Type = typ,
                ExtraBed = extrabed

            });
            dbContext.SaveChanges();

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

