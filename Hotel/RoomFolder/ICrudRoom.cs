using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.RoomFolder
{
    public interface ICrudRoom
    {
        public void Run(ApplicationDbContext dbContext);
    }
}
