using HWOOP_26._1.Properties;
using System.Numerics;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace HWOOP_26._1
{
    public partial class Game : Form
    {
        private const int SnowFlakeAmount = 500;
        private Image snowFlakeImage = Properties.Resources.Snowflake;
        private SnowFlake[] snowflakes;
        private Player player;
        private Timer timer;
        public Game()
        {
            InitializeComponent();
            DoubleBuffered = true;
            InitializeSnowfall();
            InitializeTimer();
            player = new Player(Resources.Plain, 400, 600);
            UpdatePlayer();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        player.Up();
                        UpdatePlayer();
                    }
                    break;
                case Keys.Down:
                    {
                        player.Down();
                        UpdatePlayer();
                    }
                    break;
                case Keys.Left:
                    {
                        player.Left();
                        UpdatePlayer();
                    }
                    break;
                case Keys.Right:
                    {
                        player.Right();
                        UpdatePlayer();
                    }
                    break;
            }
        }
        private void InitializeSnowfall()
        {
            Random random = new();
            snowflakes = new SnowFlake[SnowFlakeAmount];

            for (var i = 0; i < SnowFlakeAmount; i++)
            {
                var size = random.Next(15, 35);
                var x = random.Next(0, Width);
                var y = random.Next(0, Height);
                var speed = random.Next(1, 5);

                snowflakes[i] = new SnowFlake(x, y, size, speed);
            }
        }
        private void InitializeTimer()
        {
            timer = new Timer
            {
                Interval = 5
            };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private bool IsOutOfBounds(SnowFlake snowflake)
        {
            return snowflake.Y > Height;
        }

        //private void SnowfallForm_Paint(object sender, PaintEventArgs e)
        //{
        //    foreach (var snowflake in snowflakes)
        //    {
        //        e.Graphics.DrawImage(snowFlakeImage, snowflake.X, snowflake.Y, snowflake.Size, snowflake.Size);
        //    }
        //}
        private void UpdatePlayer()
        {
            pictureBoxPlayer.Location = new Point(player.X, player.Y);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (var snowflake in snowflakes)
            {
                snowflake.Fall();
                if (IsOutOfBounds(snowflake))
                {
                    snowflake.Y = -20;
                    snowflake.X = new Random().Next(0, Width);
                }
            }

            Invalidate();
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            foreach (var snowflake in snowflakes)
            {
                e.Graphics.DrawImage(snowFlakeImage, snowflake.X, snowflake.Y, snowflake.Size, snowflake.Size);
            }
        }
    }
}
