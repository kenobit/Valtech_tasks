using System.Collections.Generic;

namespace MultiplayerMain
{
    public interface IServer
    {
        Player CurrentClient { get;}
        List<Player> Clients { get; set; }
        bool Check(Player currentClient);
        void MakeMove();
    }
}
