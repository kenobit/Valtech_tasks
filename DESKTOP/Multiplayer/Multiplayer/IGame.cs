using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplayer
{
    interface IGame
    {
        void CreateNewPlayer(Player p);
        void SendDataToServer(object o);
        void MakeMove();
        void CheckWinner();
    }
}
