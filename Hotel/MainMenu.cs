using Hotel.RoomFolder;
using Hotel.GuestFolder;
using Hotel.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel;

public class MainMenu
{
    public void Run()
    {
        Console.WriteLine("1: Rooms");
        Console.WriteLine("2: Guests");
        Console.WriteLine("0: Exit");
        while (true)
        {
         var answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.Clear();
                Console.WriteLine("Please wait...");
                var app = new ApplicationRooms();
                app.Run();
                
            }
            else if (answer == "2")
            {
                Console.Clear();
                Console.WriteLine("Please wait...");
                var app = new ApplicationGuests();
                app.Run();
                
            }
            else if (answer == "0") 
            {
                Console.Clear();
                Console.WriteLine("Welcome back!");
                Environment.Exit(0);

            }
        }
    }
}

