using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplayer
{
    public class Server
    {
        public LinkedList<Player> Players = new LinkedList<Player>();
        
        public void AddPlayer(Player P)
        {
            if (Players.Count ==0)
            {
                P.IsWaiting = false;
                Players.AddFirst(P);
            }
            else
            {
                Players.AddLast(P);
            }
        }
    }
}
