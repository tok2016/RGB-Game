using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Game
{
    enum Color
    {
        White,
        Red,
        Green,
        Blue
    }

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

        public System.Drawing.Bitmap ChangeColor(Color color)
        {
            IsWhite = false;
            IsBlue = false;
            IsRed = false;
            IsGreen = false;
            if (color == Color.White)
            {
                IsWhite = true;
                return IsMovingLeft || IsMovingRight ? ChangeDirection() : ChangeToIdle();
            }
            else if(color == Color.Red)
            {
                IsRed = true;
                return IsMovingLeft || IsMovingRight ? ChangeDirection() : ChangeToIdle();
            }
            else if(color == Color.Green)
            {
                IsGreen = true;
                return IsMovingLeft || IsMovingRight ? ChangeDirection() : ChangeToIdle();
            }
            IsBlue = true;
            return IsMovingLeft || IsMovingRight ? ChangeDirection() : ChangeToIdle();
        }

        public System.Drawing.Bitmap ChangeDirection()
        {
            if(IsMovingLeft)
            {
                if (IsWhite)
                    return Properties.Resources.WCubeRunningBack;
                else if (IsRed)
                    return Properties.Resources.RCubeRunningBack;
                else if (IsGreen)
                    return Properties.Resources.GCubeRunningBack;
                else if (IsBlue)
                    return Properties.Resources.BCubeRunningBack;
            }
            if (IsWhite)
                return Properties.Resources.WCubeRunning;
            else if (IsRed)
                return Properties.Resources.RCubeRunning;
            else if (IsGreen)
                return Properties.Resources.GCubeRunning;
            return Properties.Resources.BCubeRunning;
        }

        public System.Drawing.Bitmap ChangeToIdle()
        {
            if(IsWhite)
            {
                return Properties.Resources.WCube;
            }
            else if(IsRed)
            {
                return Properties.Resources.RCube;
            }
            else if(IsGreen)
            {
                return Properties.Resources.GCube;
            }
            return Properties.Resources.BCube;
        }
    }
}
