using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MultiplayerMain
{
    public class Player: IClient
    {
        private static int id = 0;
        public Grid RootGrid { get; set; }
        private bool isWaiting;
        public int ID { get { return id; } }
        public int Scores { get; set; }
        public bool IsWaiting
        {
            get
            {
                return isWaiting;
            }

            set
            {
                isWaiting = value;
            }
        }
        
        public Player()
        {
            this.Scores = 0;
            id++;
            this.isWaiting = true;
        }

        public Player(Grid grid)
        {

            this.Scores = 0;
            id++;
            this.RootGrid = grid;
            this.isWaiting = true;
        }

        public bool Syncronise(params object[] data)
        {
            return true;
        }
    }
}
