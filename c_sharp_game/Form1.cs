using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace c_sharp_game
{
    public partial class Form1 : Form
    {
        bool in_game = false;
        bool jumping = false;
        bool pause = false;
        bool down = false;
        int jumpSpeed = 12;
        int force = 12;
        int score = 0;
        int max_score = 0;
        int obstacleSpeed = 10;
        int modeSpeed = 5;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadMaxScore();
            scoreShow();
        }

        private void gameEvent(object sender, EventArgs e)
        {

            LoopEvent();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if (x.Tag == "cloud")
                    {
                        x.Left -= obstacleSpeed - 5;
                        if (x.Left + x.Width < -120)
                        {
                            x.Left = this.ClientSize.Width + rnd.Next(100, 500);
                        }
                    }
                    else if (x.Tag == "obstacle")
                    {
                        x.Left -= obstacleSpeed;
                        if (x.Name == "bird1" || x.Name == "bird2")
                        {
                            x.Left -= 5;
                        }

                        if (x.Left + x.Width < -120)
                        {
                            int position = this.ClientSize.Width;
                            if (x.Name == "bird2" || x.Name == "bird1")
                            {
                                position += rnd.Next(1000, 10000);
                            }
                            x.Left = position + rnd.Next(100, 3000);
                        }
                        if (trex_body.Bounds.IntersectsWith(x.Bounds))
                        {
                            in_game = false;
                            pause = true;
                            gameTimer.Stop();
                            scoreTimer.Stop();
                            screen.Show();
                            difficult.Show();
                            lastKey.Hide();
                            WriteMaxScore(max_score);
                            trex.Location = new Point(383, 228);
                            trex_body.Location = new System.Drawing.Point(410, 227);
                            trex.Image = Properties.Resources.dead;
                        }

                    }
                }
            }
        }

        private void LoopEvent()
        {
            trex_body.Top = trex.Top += jumpSpeed;
            if (jumping && force < 0)
            {
                jumping = false;
            }
            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            if (trex_body.Top >= 380 && !jumping)
            {
                force = 12;
                trex_body.Top = floor.Top - trex.Height;
                trex.Top = floor.Top - trex.Height;
                jumpSpeed = 0;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            KeyEventArgs eee;
            if (e.Button.Equals(MouseButtons.Left))
            {
                eee = new KeyEventArgs(Keys.Up);
                keyisup(sender, eee);
            }
            else if (e.Button.Equals(MouseButtons.Right))
            {
                eee = new KeyEventArgs(Keys.Down);
                keyisup(sender, eee);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            KeyEventArgs eee;
            if (e.Button.Equals(MouseButtons.Left))
            {
                eee = new KeyEventArgs(Keys.Up);
                keyisdown(sender, eee);
            }
            else if (e.Button.Equals(MouseButtons.Right))
            {
                eee = new KeyEventArgs(Keys.Down);
                keyisdown(sender, eee);
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (in_game && !pause)
            {
                if (moveRight(e))
                {
                    if (this.Width - trex_body.Location.X > 100)
                    {
                        trex_body.Location = new Point(trex.Location.X + 37, trex_body.Location.Y);
                        trex.Location = new Point(trex.Location.X + 10, trex.Location.Y);
                    }
                }
                if (moveLeft(e))
                {
                    if (trex_body.Location.X > 100)
                    {
                        trex_body.Location = new Point(trex.Location.X + 17, trex_body.Location.Y);
                        trex.Location = new Point(trex.Location.X - 10, trex.Location.Y);
                    }
                }
                if (moveDown(e) && !down)
                {
                    trex.Image = c_sharp_game.Properties.Resources.down;
                    trex_body.Location = new Point(trex.Location.X + 27, trex_body.Location.Y - 10);
                    obstacleSpeed += 5;
                    down = true;
                }
                if (moveUp(e) && !jumping)
                {
                    jumping = true;
                }
                if (lastKey.Visible)
                {
                    lastKey.Text = e.KeyData.ToString().ToUpper();
                    lastKey.ForeColor = System.Drawing.Color.Orange;
                }
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (!in_game)
            {
                if (e.KeyCode == Keys.F)
                {
                    screen.Hide();
                    difficult.Hide();
                    resetGame();
                }
                if (e.KeyCode == Keys.E)
                {
                    mode.Text = "E";
                    scoreTimer.Interval = 100;
                    obstacleSpeed = 5;
                }
                if (e.KeyCode == Keys.N)
                {
                    mode.Text = "N";
                    scoreTimer.Interval = 75;
                    modeSpeed = obstacleSpeed = 10;
                }
                if (e.KeyCode == Keys.H)
                {
                    mode.Text = "H";
                    scoreTimer.Interval = 50;
                    modeSpeed = force = obstacleSpeed = 15;
                }
            }
            else
            {
                if (e.KeyCode == Keys.P)
                {
                    if (pause)
                    {
                        trex.Image = c_sharp_game.Properties.Resources.running;
                        gameTimer.Start();
                        scoreTimer.Start();
                        stop.Hide();
                        pause = false;
                    }
                    else
                    {
                        trex.Image = c_sharp_game.Properties.Resources.stop;
                        gameTimer.Stop();
                        scoreTimer.Stop();
                        stop.Show();
                        pause = true;
                    }
                }
                if (moveDown(e) || moveLeft(e) || moveRight(e) || moveUp(e))
                {
                    W.ForeColor = System.Drawing.Color.DimGray;
                    A.ForeColor = System.Drawing.Color.DimGray;
                    S.ForeColor = System.Drawing.Color.DimGray;
                    D.ForeColor = System.Drawing.Color.DimGray;
                }
                if (lastKey.Visible)
                {
                    lastKey.ForeColor = System.Drawing.Color.DimGray;
                }
                if (down && moveDown(e))
                {
                    if (!pause)
                    {
                        trex.Image = c_sharp_game.Properties.Resources.running;
                    }
                    obstacleSpeed -= 5;
                    trex_body.Location = new Point(trex.Location.X + 27, trex_body.Location.Y + 10);
                    down = false;

                }
            }
        }

        private void resetGame()
        {
            in_game = true;
            jumping = false;
            pause = false;
            down = false;
            score = 0;

            scoreShow();
            lastKey.Show();
            obstacleSpeed = modeSpeed;
            trex.Image = Properties.Resources.running;
            trex.Top = floor.Top - trex.Height;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (x.Tag == "obstacle" || x.Tag == "cloud"))
                {
                    int position;
                    if (x.Tag == "cloud")
                    {
                        position = rnd.Next(100, 300);
                    }
                    else
                    {
                        position = rnd.Next(600, 800);
                    }
                    if (x.Name == "bird2" || x.Name == "bird1")
                    {
                        position += rnd.Next(500, 2000);
                    }
                    x.Left = 640 + (x.Left + position + x.Width * 3);
                }
            }
            gameTimer.Start();
            scoreTimer.Start();
        }

        private void scoreShow()
        {
            scoreText.Text = score.ToString().PadLeft(10, '0');
            hight.Text = max_score.ToString().PadLeft(10, '0');
            Text = score.ToString().PadLeft(10, '0');
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void scoreEvent(object sender, EventArgs e)
        {
            if (max_score <= score)
            {
                max_score = score;
            }
            if ((score % 100) == 0)
            {
                obstacleSpeed += 1;
            }
            scoreShow();
            score++;
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Назым Бавбеков, группа 2ПКС-9 (2019)\n" +
                "Автор идеи: Google LLC.\n" +
                "Файлы ресурсов: trex-runner.com");
        }
        private void ReadMaxScore()
        {
            max_score = Properties.Settings.Default.max_score;
        }
        private bool moveRight(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                W.ForeColor = System.Drawing.Color.DimGray;
                A.ForeColor = System.Drawing.Color.DimGray;
                S.ForeColor = System.Drawing.Color.DimGray;
                D.ForeColor = System.Drawing.Color.Orange;
                return true;
            }
            return false;
        }

        private bool moveLeft(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                W.ForeColor = System.Drawing.Color.DimGray;
                A.ForeColor = System.Drawing.Color.Orange;
                S.ForeColor = System.Drawing.Color.DimGray;
                D.ForeColor = System.Drawing.Color.DimGray;
                return true;
            }
            return false;
        }

        private bool moveDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                W.ForeColor = System.Drawing.Color.DimGray;
                A.ForeColor = System.Drawing.Color.DimGray;
                S.ForeColor = System.Drawing.Color.Orange;
                D.ForeColor = System.Drawing.Color.DimGray;
                return true;
            }
            return false;
        }

        private bool moveUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                W.ForeColor = System.Drawing.Color.Orange;
                A.ForeColor = System.Drawing.Color.DimGray;
                S.ForeColor = System.Drawing.Color.DimGray;
                D.ForeColor = System.Drawing.Color.DimGray;
                return true;
            }
            return false;
        }

        private void WriteMaxScore(int score)
        {
            Properties.Settings.Default.max_score = score;
            Properties.Settings.Default.Save();
        }
    }
}
