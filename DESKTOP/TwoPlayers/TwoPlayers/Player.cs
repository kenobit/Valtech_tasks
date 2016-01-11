using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayers
{
    class Player
    {
        public string Name { get; set; }
        public bool isRealPlayer { get; set; }
        public Player(string name)
        {
            this.Name = name;
            this.isRealPlayer = true;
        }

        public Player()
        {
            this.Name = "Computer";
            this.isRealPlayer = false;
        }

        
        public Player(string name, bool isReal)
        {
            this.Name = name;
            this.isRealPlayer = isReal;
        }
    }
}
