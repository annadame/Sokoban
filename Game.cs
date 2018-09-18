using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modelSokoban
{
    public class Game
    {
        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }

        public Field Field
        {
            get => default(Field);
            set
            {
            }
        }

        public void CheckWin()
        {
            throw new System.NotImplementedException();
        }
    }
}