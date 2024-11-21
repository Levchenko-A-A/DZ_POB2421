namespace HWOOP_26._1
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBoxPlayer = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.BackColor = Color.Transparent;
            pictureBoxPlayer.BackgroundImage = Properties.Resources.Snowflake;
            pictureBoxPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxPlayer.Location = new Point(450, 600);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(65, 56);
            pictureBoxPlayer.TabIndex = 0;
            pictureBoxPlayer.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer_Tick;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(877, 674);
            Controls.Add(pictureBoxPlayer);
            Name = "Game";
            Text = "Снег";
            Paint += Game_Paint;
            KeyDown += Game_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Timer timer1;
    }
}
