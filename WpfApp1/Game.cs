using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Game
    {
        private int player;

        public int Player
        {
            get { return player; }
            set { player = value; }
        }
        public Game(int player)
        {
            this.player = player;
            
        }

    }
}
