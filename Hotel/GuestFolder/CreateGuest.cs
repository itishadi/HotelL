using Hotel.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.GuestFolder
{
    public class CreateGuest : ICrudGuest
    {
        public void Run(ApplicationDbContext dbContext)
        {
            Console.Clear();
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("How old are you?");
            var age = Convert.ToInt32(Console.ReadLine());


            Console.Clear();
            Console.WriteLine("What is your IDNumber/Personnummer?");
            var guestIdInput = Console.ReadLine();
        
            dbContext.Guests.Add(new Guest
            {
                GuestId = guestIdInput,
                Name = name,
                Age = age,
            });
            Console.Clear();
            Console.WriteLine("Enter to see all guestes!");
            dbContext.SaveChanges();
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

