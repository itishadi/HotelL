using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data
{
    public class DatainItializer
    {
        public void MigrateAndSeed(ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            SeedRooms(dbContext);
            SeedGuests(dbContext);
            dbContext.SaveChanges();
        }

        private void SeedRooms(ApplicationDbContext dbContext)
        {
            if (!dbContext.Rooms.Any(c => c.RoomId == "A"))
            {
                dbContext.Rooms.Add(new Room
                {
                    RoomId = "A",
                    Description = "Singelroom!",
                    Type = "Quadruple",
                    ExtraBed = "no"

                });
            }
            if (!dbContext.Rooms.Any(c => c.RoomId == "B"))
            {
                dbContext.Rooms.Add(new Room
                {
                    RoomId = "B",
                    Description = "Singelroom!",
                    Type = "Twin",
                    ExtraBed = "NO"

                });
            }
            if (!dbContext.Rooms.Any(c => c.RoomId == "C"))
            {
                dbContext.Rooms.Add(new Room
                {
                    RoomId = "C",
                    Description = "Doublerum!",
                    Type = "Triple",
                    ExtraBed = "YES"

                });
            }
            if (!dbContext.Rooms.Any(c => c.RoomId == "D"))
            {
                dbContext.Rooms.Add(new Room
                {
                    RoomId = "D",
                    Description = "Doublerum!",
                    Type = "Triple",
                    ExtraBed = "YES"

                });
            }
           
        }

            private void SeedGuests(ApplicationDbContext dbContext)
            {
                if (!dbContext.Guests.Any(c => c.Name == "Johan"))
                {
                    dbContext.Guests.Add(new Guest
                    {
                       GuestId = "Johan",
                       Name = "Johan",
                       Age = 41,

                    });
                }
            if (!dbContext.Guests.Any(c => c.Name == "Edward"))
            {
                dbContext.Guests.Add(new Guest
                {
                    GuestId = "Edward",
                    Name = "Edward",
                    Age = 25,

                });
            }
            if (!dbContext.Guests.Any(c => c.Name == "Richard"))
            {
                dbContext.Guests.Add(new Guest
                {
                    GuestId = "Richard",
                    Name = "Richard",
                    Age = 35,

                });
            }
            if (!dbContext.Guests.Any(c => c.Name == "Stefan"))
            {
                dbContext.Guests.Add(new Guest
                {
                    GuestId = "Stefan",
                    Name = "Stefan",
                    Age = 36,

                });
            }
        }
            
    }
}
