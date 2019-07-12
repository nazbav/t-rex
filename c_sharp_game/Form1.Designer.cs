namespace c_sharp_game
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
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.hight = new System.Windows.Forms.Label();
            this.trex_body = new System.Windows.Forms.Label();
            this.scoreTimer = new System.Windows.Forms.Timer(this.components);
            this.difficult = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.W = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.trex = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.bird2 = new System.Windows.Forms.PictureBox();
            this.bird1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.about = new System.Windows.Forms.Label();
            this.lastKey = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Label();
            this.cloud3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.scoreText.ForeColor = System.Drawing.Color.DimGray;
            this.scoreText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scoreText.Location = new System.Drawing.Point(11, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(120, 24);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "0000000000";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameEvent);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.screen.ForeColor = System.Drawing.Color.DimGray;
            this.screen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.screen.Location = new System.Drawing.Point(-5, -12);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(915, 602);
            this.screen.TabIndex = 8;
            this.screen.Text = "Нажмите F чтобы начать";
            this.screen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.close.ForeColor = System.Drawing.Color.DimGray;
            this.close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.close.Location = new System.Drawing.Point(865, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.TabIndex = 9;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // hight
            // 
            this.hight.AutoSize = true;
            this.hight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.hight.ForeColor = System.Drawing.Color.DarkGray;
            this.hight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hight.Location = new System.Drawing.Point(137, 9);
            this.hight.Name = "hight";
            this.hight.Size = new System.Drawing.Size(120, 24);
            this.hight.TabIndex = 16;
            this.hight.Text = "0000000000";
            // 
            // trex_body
            // 
            this.trex_body.BackColor = System.Drawing.Color.Transparent;
            this.trex_body.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trex_body.Location = new System.Drawing.Point(410, 227);
            this.trex_body.Name = "trex_body";
            this.trex_body.Size = new System.Drawing.Size(10, 10);
            this.trex_body.TabIndex = 17;
            this.trex_body.Text = " ";
            // 
            // scoreTimer
            // 
            this.scoreTimer.Tick += new System.EventHandler(this.scoreEvent);
            // 
            // difficult
            // 
            this.difficult.AutoSize = true;
            this.difficult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.difficult.ForeColor = System.Drawing.Color.DimGray;
            this.difficult.Location = new System.Drawing.Point(12, 511);
            this.difficult.Name = "difficult";
            this.difficult.Size = new System.Drawing.Size(259, 68);
            this.difficult.TabIndex = 18;
            this.difficult.Text = "Режимы сложности (нажмите кнопку):\r\nE - Просто\r\nN - Нормально\r\nH - Сложно\r\n";
            // 
            // mode
            // 
            this.mode.AutoSize = true;
            this.mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mode.ForeColor = System.Drawing.Color.Orange;
            this.mode.Location = new System.Drawing.Point(263, 9);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(23, 24);
            this.mode.TabIndex = 19;
            this.mode.Text = "E";
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D.ForeColor = System.Drawing.Color.DimGray;
            this.D.Location = new System.Drawing.Point(848, 555);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(23, 24);
            this.D.TabIndex = 20;
            this.D.Tag = "right";
            this.D.Text = "D";
            // 
            // W
            // 
            this.W.AutoSize = true;
            this.W.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.W.ForeColor = System.Drawing.Color.DimGray;
            this.W.Location = new System.Drawing.Point(817, 527);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(28, 24);
            this.W.TabIndex = 21;
            this.W.Tag = "up";
            this.W.Text = "W";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A.ForeColor = System.Drawing.Color.DimGray;
            this.A.Location = new System.Drawing.Point(791, 555);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(23, 24);
            this.A.TabIndex = 22;
            this.A.Tag = "left";
            this.A.Text = "A";
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.S.ForeColor = System.Drawing.Color.DimGray;
            this.S.Location = new System.Drawing.Point(820, 555);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(22, 24);
            this.S.TabIndex = 23;
            this.S.Tag = "down";
            this.S.Text = "S";
            // 
            // trex
            // 
            this.trex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trex.BackColor = System.Drawing.Color.Transparent;
            this.trex.Image = global::c_sharp_game.Properties.Resources.start;
            this.trex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trex.Location = new System.Drawing.Point(383, 228);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(40, 43);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trex.TabIndex = 1;
            this.trex.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Transparent;
            this.floor.Image = global::c_sharp_game.Properties.Resources.floor;
            this.floor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.floor.Location = new System.Drawing.Point(0, 451);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(906, 12);
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            this.floor.Tag = "floor";
            // 
            // bird2
            // 
            this.bird2.Image = global::c_sharp_game.Properties.Resources.birts;
            this.bird2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bird2.Location = new System.Drawing.Point(847, 318);
            this.bird2.Name = "bird2";
            this.bird2.Size = new System.Drawing.Size(42, 37);
            this.bird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bird2.TabIndex = 7;
            this.bird2.TabStop = false;
            this.bird2.Tag = "obstacle";
            // 
            // bird1
            // 
            this.bird1.Image = global::c_sharp_game.Properties.Resources.birts;
            this.bird1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bird1.Location = new System.Drawing.Point(538, 376);
            this.bird1.Name = "bird1";
            this.bird1.Size = new System.Drawing.Size(42, 37);
            this.bird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bird1.TabIndex = 6;
            this.bird1.TabStop = false;
            this.bird1.Tag = "obstacle";
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::c_sharp_game.Properties.Resources.obstacle2;
            this.obstacle2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.obstacle2.Location = new System.Drawing.Point(847, 400);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(50, 50);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2.TabIndex = 4;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::c_sharp_game.Properties.Resources.obstacle1;
            this.obstacle1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.obstacle1.Location = new System.Drawing.Point(538, 417);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(15, 33);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 3;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // cloud1
            // 
            this.cloud1.BackColor = System.Drawing.Color.Transparent;
            this.cloud1.Image = global::c_sharp_game.Properties.Resources.cloud1;
            this.cloud1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cloud1.Location = new System.Drawing.Point(607, 85);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(41, 13);
            this.cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cloud1.TabIndex = 10;
            this.cloud1.TabStop = false;
            this.cloud1.Tag = "cloud";
            // 
            // cloud2
            // 
            this.cloud2.BackColor = System.Drawing.Color.Transparent;
            this.cloud2.Image = global::c_sharp_game.Properties.Resources.cloud2;
            this.cloud2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cloud2.Location = new System.Drawing.Point(704, 149);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(58, 20);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cloud2.TabIndex = 13;
            this.cloud2.TabStop = false;
            this.cloud2.Tag = "cloud";
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.about.ForeColor = System.Drawing.Color.DimGray;
            this.about.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.about.Location = new System.Drawing.Point(839, 9);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(20, 24);
            this.about.TabIndex = 24;
            this.about.Text = "?";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // lastKey
            // 
            this.lastKey.AutoSize = true;
            this.lastKey.BackColor = System.Drawing.Color.Transparent;
            this.lastKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastKey.ForeColor = System.Drawing.Color.DimGray;
            this.lastKey.Location = new System.Drawing.Point(12, 555);
            this.lastKey.Name = "lastKey";
            this.lastKey.Size = new System.Drawing.Size(73, 24);
            this.lastKey.TabIndex = 25;
            this.lastKey.Text = "SPACE";
            this.lastKey.Visible = false;
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop.ForeColor = System.Drawing.Color.Red;
            this.stop.Location = new System.Drawing.Point(292, 9);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(22, 24);
            this.stop.TabIndex = 26;
            this.stop.Text = "P";
            this.stop.Visible = false;
            // 
            // cloud3
            // 
            this.cloud3.BackColor = System.Drawing.Color.Transparent;
            this.cloud3.Image = global::c_sharp_game.Properties.Resources.cloud3;
            this.cloud3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cloud3.Location = new System.Drawing.Point(744, 202);
            this.cloud3.Name = "cloud3";
            this.cloud3.Size = new System.Drawing.Size(81, 24);
            this.cloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cloud3.TabIndex = 27;
            this.cloud3.TabStop = false;
            this.cloud3.Tag = "cloud";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 588);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.about);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.difficult);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.hight);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.close);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.bird2);
            this.Controls.Add(this.bird1);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.cloud1);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.cloud3);
            this.Controls.Add(this.lastKey);
            this.Controls.Add(this.W);
            this.Controls.Add(this.A);
            this.Controls.Add(this.S);
            this.Controls.Add(this.D);
            this.Controls.Add(this.trex_body);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T-Rex";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox bird1;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox bird2;
        private System.Windows.Forms.Label screen;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.PictureBox cloud2;
        private System.Windows.Forms.Label hight;
        private System.Windows.Forms.Label trex_body;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.Label difficult;
        private System.Windows.Forms.Label mode;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label W;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label about;
        private System.Windows.Forms.Label lastKey;
        private System.Windows.Forms.Label stop;
        private System.Windows.Forms.PictureBox cloud3;
    }
}

