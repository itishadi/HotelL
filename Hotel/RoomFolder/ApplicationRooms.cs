using Hotel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.RoomFolder
{
    public class ApplicationRooms
    {
        public void Run( )
        {
            var buildApp = new Build();
            var dbContext = buildApp.BuildApp();
            bool run;

            while (run = true)
            {
                Console.Clear();

                var sel = MainMenuRoom.ShowRoomMenu(dbContext);
                switch (sel)
                {
                    case 1:
                        {
                            var action = new CreateRoom();
                            action.Run(dbContext);
                            break;
                        }
                    case 2:
                        {
                            var action = new ReadRoom();
                            action.Run(dbContext);
                            break;
                        }
                    case 3:
                        {
                            var action = new UpdateRoom();
                            action.Run(dbContext);
                            break;
                        }
                    case 4:
                        {
                            var action = new DeleteRoom();
                            action.Run(dbContext);
                            break;
                        }
                    case 0:
                        {
                            Console.Clear();
                            var action = new MainMenu();
                            action.Run();
                            break;
                        }
                    default:
                        break;
                }
            }
            List<ICrudRoom> actions = new List<ICrudRoom>();
            var c = new CreateRoom();
            var r = new ReadRoom();
            var u = new UpdateRoom();
            var d = new DeleteRoom();

            actions.Add(c);
            actions.Add(r);
            actions.Add(u);
            actions.Add(d);
            foreach (var action in actions)
            {
                action.Run(dbContext);
            }
        }
    }
}
