﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.GuestFolder
{
    public class ReadGuest : ICrudGuest
    {
        public void Run(ApplicationDbContext dbContext)
        {
            Console.WriteLine("(R)EAD alla personer!");
            Console.WriteLine("=====================");

            Console.WriteLine("====================\n");
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
