using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Game
{
    class Player
    {
        public int MoveSpeed { get; set; }
        public int JumpSpeed { get; set; }
        public int Force { get; set; }
        public bool IsMovingRight { get; set; }
        public bool IsMovingLeft { get; set; }
        public bool IsJumping { get; set; }
        public bool IsRed { get; set; }
        public bool IsGreen { get; set; }
        public bool IsBlue { get; set; }
        public bool IsWhite { get; set; }

        public Player(int moveVelocity)
        {
            MoveSpeed = moveVelocity;
        }
    }
}
