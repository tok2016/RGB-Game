using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_Game
{
    public partial class Form1 : Form
    {
        Player playerOptions  = new Player(8);
        bool isGameOver;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimer(object sender, EventArgs e)
        {
            player.Top += playerOptions.JumpSpeed;
            //if (playerOptions.IsMovingRight)
            //    player.Left += playerOptions.MoveSpeed;
            //if (playerOptions.IsMovingLeft)
            //    player.Left -= playerOptions.MoveSpeed;
            if (playerOptions.IsJumping && playerOptions.Force < 0)
                playerOptions.IsJumping = false;
            if(playerOptions.IsJumping)
            {
                playerOptions.Force -= 1;
                playerOptions.JumpSpeed = -12;
            }
            else
            {
                playerOptions.JumpSpeed = 10;
            }
            foreach(Control sprite in this.Controls)
            {
                if(sprite is PictureBox)
                {
                    if((string)sprite.Tag == "platform" || !playerOptions.IsRed && (string)sprite.Tag == "redPlatform")
                    {
                        if(player.Bounds.IntersectsWith(sprite.Bounds))
                        {
                            playerOptions.Force = 8;
                            player.Top = sprite.Top - player.Height;
                        }

                        player.BringToFront(); //not that necessary so far
                    }
                    if ((string)sprite.Tag == "redSpike" && !playerOptions.IsRed)
                    {
                        if(player.Bounds.IntersectsWith(new Rectangle(sprite.Left + 6, sprite.Top + 12, sprite.Width - 6, sprite.Height - 5)))
                        {
                            isGameOver = true;
                            Restart();
                        }
                    }
                }
            }

            if(player.Top + player.Height > ClientSize.Height + 60)
            {
                isGameOver = true;
                Restart();
            }
        }

        private void KeyGetDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                //playerOptions.IsMovingRight = true;
                rightTimer.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                //playerOptions.IsMovingLeft = true;
                leftTimer.Start();
            }
            if (e.KeyCode == Keys.Space && !playerOptions.IsJumping)
                playerOptions.IsJumping = true;
            if(e.KeyCode == Keys.A)
            {
                playerOptions.IsRed = true;
                player.Image = Properties.Resources.RedCubeRunning;
            }
            if(e.KeyCode == Keys.W)
            {
                playerOptions.IsWhite = true;
                player.Image = Properties.Resources.CubeRunning;
            }
            if (isGameOver && e.KeyCode == Keys.Enter)
                Restart();
        }

        private void KeyGetUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) rightTimer.Stop();
            //playerOptions.IsMovingRight = false;
            if (e.KeyCode == Keys.Left) leftTimer.Stop();
                //playerOptions.IsMovingLeft = false;
            if (playerOptions.IsJumping)
                playerOptions.IsJumping = false;
        }

        private void Restart()
        {
            playerOptions.IsJumping = false;
            playerOptions.IsMovingLeft = false;
            playerOptions.IsMovingRight = false;
            playerOptions.IsWhite = true;
            playerOptions.IsRed = false;
            playerOptions.IsGreen = false;
            playerOptions.IsBlue = false;
            player.Image = Properties.Resources.CubeRunning;
            isGameOver = false;
            player.Left = 74;
            player.Top = 450;
            gameTimer.Start();
        }

        private void rightTimer_Tick(object sender, EventArgs e)
        {
            if (player.Left < 1150)
                player.Left += playerOptions.MoveSpeed;
        }

        private void leftTimer_Tick(object sender, EventArgs e)
        {
            if (player.Left > 0)
                player.Left -= playerOptions.MoveSpeed;
        }
    }
}
