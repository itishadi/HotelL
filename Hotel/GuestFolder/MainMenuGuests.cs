using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.GuestFolder
{
    public static class MainMenuGuests
    {
        public static int ShowGuestMenu(ApplicationDbContext dbContext)
        {

            Console.WriteLine("1: Create a guest");
            Console.WriteLine("2: Read all guest");
            Console.WriteLine("3: Update a guest");
            Console.WriteLine("4: Delete a guest");
            Console.WriteLine("0: Exit");

            var sel = Convert.ToInt32(Console.ReadLine());
            return sel;
        }
    }
}
