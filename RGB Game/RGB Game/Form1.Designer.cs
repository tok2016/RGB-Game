
namespace RGB_Game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.redSpike = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.rightTimer = new System.Windows.Forms.Timer(this.components);
            this.leftTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSpike)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::RGB_Game.Properties.Resources.CubeRunning;
            this.player.Location = new System.Drawing.Point(74, 450);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(85, 104);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(-5, 560);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(531, 120);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.Location = new System.Drawing.Point(664, 560);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(605, 120);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "redPlatform";
            // 
            // redSpike
            // 
            this.redSpike.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.redSpike.Cursor = System.Windows.Forms.Cursors.Default;
            this.redSpike.Image = global::RGB_Game.Properties.Resources.RedSpike1;
            this.redSpike.Location = new System.Drawing.Point(948, 521);
            this.redSpike.Name = "redSpike";
            this.redSpike.Size = new System.Drawing.Size(53, 41);
            this.redSpike.TabIndex = 3;
            this.redSpike.TabStop = false;
            this.redSpike.Tag = "redSpike";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer);
            // 
            // rightTimer
            // 
            this.rightTimer.Interval = 20;
            this.rightTimer.Tick += new System.EventHandler(this.rightTimer_Tick);
            // 
            // leftTimer
            // 
            this.leftTimer.Interval = 20;
            this.leftTimer.Tick += new System.EventHandler(this.leftTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RGB_Game.Properties.Resources.BG1_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.redSpike);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "RGB";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyGetDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyGetUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSpike)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox redSpike;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer rightTimer;
        private System.Windows.Forms.Timer leftTimer;
    }
}

