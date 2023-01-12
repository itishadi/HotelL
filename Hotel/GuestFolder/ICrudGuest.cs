using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.GuestFolder
{
    public interface ICrudGuest
    {
        public void Run(ApplicationDbContext dbContext);
    }
}
