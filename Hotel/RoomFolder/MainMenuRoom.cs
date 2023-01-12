using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.RoomFolder
{
    public static class MainMenuRoom
    {
        public static int ShowRoomMenu(ApplicationDbContext dbContext)
        {
           
                        Console.WriteLine("1: Create a room");
                        Console.WriteLine("2: Read all rooms");
                        Console.WriteLine("3: Update a room");
                        Console.WriteLine("4: Delete a room");
                        Console.WriteLine("0: Exit");

                        var sel = Convert.ToInt32(Console.ReadLine());
                        return sel;
        }
    }
}
