using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplayer
{
    public class Player
    {
        private static int ID;
        public string Name { get; set; }
        public int Id
        {
            get
            {
                return ID;
            }
        }
        
        public bool IsWaiting { get; set; }
        public bool IsHuman { get; }
        public Player(string name)
        {
            ID++;
            this.Name = name;
            this.IsWaiting = true;
            this.IsHuman = true;

        }
        public Player(string name, bool isWaiting)
        {
            ID++;
            this.Name = name;
            this.IsWaiting = isWaiting;
            this.IsHuman = true;

        }

        public Player(string name, bool isWaiting, bool isHuman)
        {
            ID++;
            this.Name = name;
            this.IsWaiting = isWaiting;
            this.IsHuman = IsHuman;
        }
    }
}
