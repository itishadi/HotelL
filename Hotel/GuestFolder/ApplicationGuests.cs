using Hotel.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.GuestFolder
{
    public class ApplicationGuests
    {
        public void Run()
        {
            var buildApp = new Build();
            var dbContext = buildApp.BuildApp();
            bool run;
            while (run = true)
            {
                Console.Clear();



                var sel = MainMenuGuests.ShowGuestMenu(dbContext);
                switch (sel)
                {
                    case 1:
                        {
                            var action = new CreateGuest();
                            action.Run(dbContext);

                            break;
                        }
                    case 2:
                        {
                            var action = new ReadGuest();
                            action.Run(dbContext);
                            break;
                        }
                    case 3:
                        {
                            var action = new UpdateGuest();
                            action.Run(dbContext);
                            break;
                        }
                    case 4:
                        {
                            var action = new DeleteGuest();
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
            List<ICrudGuest> actions = new List<ICrudGuest>();
            var c = new CreateGuest();
            var r = new ReadGuest();
            var u = new UpdateGuest();
            var d = new DeleteGuest();
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

