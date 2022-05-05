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
            player.Image = playerOptions.ChangeColor(Color.White);
        }

        private void GameTimer(object sender, EventArgs e)
        {
            //if(player.Right > platform.Left && player.Left < platform.Right - player.Width / 2 && player.Bottom > platform.Top)
            //{
            //    playerOptions.IsMovingRight = false;
            //}
            //if (player.Left < platform.Right && player.Right > platform.Left + player.Width / 2 && player.Bottom > platform.Top)
            //{
            //    playerOptions.IsMovingLeft = false;
            //}
            //if(player.Left + player.Width - 1 > platform.Left 
            //    && player.Width + player.Left + 5 < platform.Left + platform.Width + player.Width 
            //    && player.Top + player.Height >= platform.Top && player.Top < platform.Top)
            //{
            //    player.Top = ClientSize.Height - platform.Height - player.Height;
            //    playerOptions.Force = 0;
            //    playerOptions.IsJumping = false;
            //}
            //player.Top += playerOptions.JumpSpeed;
            if (playerOptions.IsMovingRight)
                player.Left += playerOptions.MoveSpeed;
            if (playerOptions.IsMovingLeft)
                player.Left -= playerOptions.MoveSpeed;
            //if (playerOptions.IsJumping && playerOptions.Force < 0)
            //    playerOptions.IsJumping = false;
            //if(playerOptions.IsJumping)
            //{
            //    playerOptions.Force -= 1;
            //    playerOptions.JumpSpeed = -12;
            //}
            //else
            //{
            //    playerOptions.JumpSpeed = 9;
            //}

            if (playerOptions.IsJumping)
            {
                player.Top -= playerOptions.Force;
                playerOptions.Force--;
            }
            else
            {
                player.Top += 10;
            }

            foreach (Control sprite in this.Controls)
            {
                if (sprite is PictureBox)
                {
                    if ((string)sprite.Tag == "platform" || !playerOptions.IsRed && (string)sprite.Tag == "redPlatform")
                    {
                        if (player.Bounds.IntersectsWith(sprite.Bounds))
                        {
                            playerOptions.Force = 16;
                            player.Top = sprite.Top - player.Height;
                            playerOptions.JumpSpeed = 0;
                        }
                        player.BringToFront(); //not that necessary so far
                    }
                    if ((string)sprite.Tag == "redSpike" && !playerOptions.IsRed)
                    {
                        if (player.Bounds.IntersectsWith(new Rectangle(sprite.Left + 6, sprite.Top + 12, sprite.Width - 6, sprite.Height - 5)))
                        {
                            isGameOver = true;
                            Restart();
                        }
                    }
                }
            }

            if (player.Top + player.Height > ClientSize.Height + 60)
            {
                isGameOver = true;
                Restart();
            }
        }

        private void KeyGetDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                playerOptions.IsMovingRight = true;
                playerOptions.IsMovingLeft = false;
                player.Image = playerOptions.ChangeDirection();
                //rightTimer.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                playerOptions.IsMovingLeft = true;
                playerOptions.IsMovingRight = false;
                player.Image = playerOptions.ChangeDirection();
                //leftTimer.Start();
            }
            if (e.KeyCode == Keys.Space && !playerOptions.IsJumping)
            {
                playerOptions.IsJumping = true;
                playerOptions.Force = 16;
            }
            if(e.KeyCode == Keys.A)
            {
                player.Image = playerOptions.ChangeColor(Color.Red);
            }
            if(e.KeyCode == Keys.S)
            {
                player.Image = playerOptions.ChangeColor(Color.Green);
            }
            if(e.KeyCode == Keys.D)
            {
                player.Image = playerOptions.ChangeColor(Color.Blue);
            }
            if(e.KeyCode == Keys.W)
            {
                player.Image = playerOptions.ChangeColor(Color.White);
            }
            if (isGameOver && e.KeyCode == Keys.Enter)
                Restart();
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void KeyGetUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                //rightTimer.Stop();
                playerOptions.IsMovingRight = false;
                player.Image = playerOptions.ChangeToIdle();
            }
            if (e.KeyCode == Keys.Left)
            {
                //leftTimer.Stop();
                playerOptions.IsMovingLeft = false;
                player.Image = playerOptions.ChangeToIdle();
            }
            if (playerOptions.IsJumping)
                playerOptions.IsJumping = false;
            //player.Image = playerOptions.ChangeToIdle();
        }

        private void Restart()
        {
            playerOptions.IsJumping = false;
            playerOptions.IsMovingLeft = false;
            playerOptions.IsMovingRight = false;
            player.Image = playerOptions.ChangeColor(Color.White);
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
