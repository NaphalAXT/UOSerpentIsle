using System;
using Server.Network;
using Server.Engines.Quests;
using Server.Mobiles;
using System.Collections.Generic;
using System.Linq;
using Server.Gumps;

namespace Server.Misc
{
    public class LoginStats
    {
        public static void Initialize()
        {
            // Register our event handler
            EventSink.Login += new LoginEventHandler(EventSink_Login);
        }

        private static void EventSink_Login(LoginEventArgs args)
        {
            int userCount = NetState.Instances.Count;
            int itemCount = World.Items.Count;
            int mobileCount = World.Mobiles.Count;

            Mobile m = args.Mobile;

            m.SendMessage("Welcome, {0}! There {1} currently {2} user{3} online, with {4} item{5} and {6} mobile{7} in the world.",
                args.Mobile.Name,
                userCount == 1 ? "is" : "are",
                userCount, userCount == 1 ? "" : "s",
                itemCount, itemCount == 1 ? "" : "s",
                mobileCount, mobileCount == 1 ? "" : "s");

            if (m.IsStaff())
            {
                Server.Engines.Help.PageQueue.Pages_OnCalled(m);
            }

            //UOSI - This is the old WelcomeGump. Replaced it with VNC MOTD System.
            //m.CloseGump(typeof(WelcomeGump));
            //m.SendGump(new WelcomeGump());
        }
    }
}
