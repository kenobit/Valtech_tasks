using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayers
{
    interface IMultiplayer
    {
        void Turn(Player p);

        void Win(Player p);

        void Loose(Player p);
    }
}
