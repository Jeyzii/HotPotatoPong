namespace HotPotatoPong
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.imgBall = new System.Windows.Forms.PictureBox();
            this.Paddle1 = new System.Windows.Forms.PictureBox();
            this.Paddle2 = new System.Windows.Forms.PictureBox();
            this.atimer = new System.Windows.Forms.Timer(this.components);
            this.BorderDown = new System.Windows.Forms.PictureBox();
            this.BorderUp = new System.Windows.Forms.PictureBox();
            this.BorderLeft = new System.Windows.Forms.PictureBox();
            this.BorderRight = new System.Windows.Forms.PictureBox();
            this.P1Point = new System.Windows.Forms.Label();
            this.P2Point = new System.Windows.Forms.Label();
            this.Finisher = new System.Windows.Forms.PictureBox();
            this.SmallPaddle = new System.Windows.Forms.PictureBox();
            this.PaddleFast = new System.Windows.Forms.PictureBox();
            this.Invisiball = new System.Windows.Forms.PictureBox();
            this.endgameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finisher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddleFast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Invisiball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBall
            // 
            this.imgBall.BackColor = System.Drawing.Color.Transparent;
            this.imgBall.Image = ((System.Drawing.Image)(resources.GetObject("imgBall.Image")));
            this.imgBall.Location = new System.Drawing.Point(469, 268);
            this.imgBall.Name = "imgBall";
            this.imgBall.Size = new System.Drawing.Size(41, 34);
            this.imgBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBall.TabIndex = 0;
            this.imgBall.TabStop = false;
            // 
            // Paddle1
            // 
            this.Paddle1.Image = ((System.Drawing.Image)(resources.GetObject("Paddle1.Image")));
            this.Paddle1.Location = new System.Drawing.Point(12, 86);
            this.Paddle1.Name = "Paddle1";
            this.Paddle1.Size = new System.Drawing.Size(18, 128);
            this.Paddle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Paddle1.TabIndex = 1;
            this.Paddle1.TabStop = false;
            // 
            // Paddle2
            // 
            this.Paddle2.Image = ((System.Drawing.Image)(resources.GetObject("Paddle2.Image")));
            this.Paddle2.Location = new System.Drawing.Point(947, 385);
            this.Paddle2.Name = "Paddle2";
            this.Paddle2.Size = new System.Drawing.Size(18, 128);
            this.Paddle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Paddle2.TabIndex = 2;
            this.Paddle2.TabStop = false;
            // 
            // atimer
            // 
            this.atimer.Enabled = true;
            this.atimer.Interval = 1;
            this.atimer.Tick += new System.EventHandler(this.atimer_Tick);
            // 
            // BorderDown
            // 
            this.BorderDown.Location = new System.Drawing.Point(0, 519);
            this.BorderDown.Name = "BorderDown";
            this.BorderDown.Size = new System.Drawing.Size(980, 9);
            this.BorderDown.TabIndex = 3;
            this.BorderDown.TabStop = false;
            // 
            // BorderUp
            // 
            this.BorderUp.Location = new System.Drawing.Point(0, 43);
            this.BorderUp.Name = "BorderUp";
            this.BorderUp.Size = new System.Drawing.Size(980, 10);
            this.BorderUp.TabIndex = 4;
            this.BorderUp.TabStop = false;
            // 
            // BorderLeft
            // 
            this.BorderLeft.Location = new System.Drawing.Point(-4, 43);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(10, 484);
            this.BorderLeft.TabIndex = 5;
            this.BorderLeft.TabStop = false;
            // 
            // BorderRight
            // 
            this.BorderRight.Location = new System.Drawing.Point(974, 43);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(10, 484);
            this.BorderRight.TabIndex = 6;
            this.BorderRight.TabStop = false;
            // 
            // P1Point
            // 
            this.P1Point.AutoSize = true;
            this.P1Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Point.Location = new System.Drawing.Point(373, 13);
            this.P1Point.Name = "P1Point";
            this.P1Point.Size = new System.Drawing.Size(29, 31);
            this.P1Point.TabIndex = 7;
            this.P1Point.Text = "0";
            // 
            // P2Point
            // 
            this.P2Point.AutoSize = true;
            this.P2Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Point.Location = new System.Drawing.Point(579, 13);
            this.P2Point.Name = "P2Point";
            this.P2Point.Size = new System.Drawing.Size(29, 31);
            this.P2Point.TabIndex = 8;
            this.P2Point.Text = "0";
            // 
            // Finisher
            // 
            this.Finisher.BackColor = System.Drawing.Color.Transparent;
            this.Finisher.Image = ((System.Drawing.Image)(resources.GetObject("Finisher.Image")));
            this.Finisher.Location = new System.Drawing.Point(322, 7);
            this.Finisher.Name = "Finisher";
            this.Finisher.Size = new System.Drawing.Size(31, 31);
            this.Finisher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Finisher.TabIndex = 9;
            this.Finisher.TabStop = false;
            this.Finisher.Visible = false;
            // 
            // SmallPaddle
            // 
            this.SmallPaddle.BackColor = System.Drawing.Color.Transparent;
            this.SmallPaddle.Image = ((System.Drawing.Image)(resources.GetObject("SmallPaddle.Image")));
            this.SmallPaddle.Location = new System.Drawing.Point(322, 395);
            this.SmallPaddle.Name = "SmallPaddle";
            this.SmallPaddle.Size = new System.Drawing.Size(27, 32);
            this.SmallPaddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SmallPaddle.TabIndex = 10;
            this.SmallPaddle.TabStop = false;
            // 
            // PaddleFast
            // 
            this.PaddleFast.BackColor = System.Drawing.Color.Transparent;
            this.PaddleFast.Image = ((System.Drawing.Image)(resources.GetObject("PaddleFast.Image")));
            this.PaddleFast.Location = new System.Drawing.Point(298, 140);
            this.PaddleFast.Name = "PaddleFast";
            this.PaddleFast.Size = new System.Drawing.Size(39, 34);
            this.PaddleFast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PaddleFast.TabIndex = 11;
            this.PaddleFast.TabStop = false;
            this.PaddleFast.Tag = "powerups";
            // 
            // Invisiball
            // 
            this.Invisiball.Image = ((System.Drawing.Image)(resources.GetObject("Invisiball.Image")));
            this.Invisiball.Location = new System.Drawing.Point(672, 395);
            this.Invisiball.Name = "Invisiball";
            this.Invisiball.Size = new System.Drawing.Size(54, 34);
            this.Invisiball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Invisiball.TabIndex = 12;
            this.Invisiball.TabStop = false;
            // 
            // endgameTimer
            // 
            this.endgameTimer.Enabled = true;
            this.endgameTimer.Interval = 20000;
            this.endgameTimer.Tick += new System.EventHandler(this.endgameTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 534);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(361, 536);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(563, 537);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "powerups";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(796, 537);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Makes the ball Invisible for 2 seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "shrinks the paddles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(608, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "makes the paddles faster";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(833, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "ENDS THE GAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(417, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 39);
            this.label5.TabIndex = 22;
            this.label5.Text = "SCORE";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 575);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Invisiball);
            this.Controls.Add(this.PaddleFast);
            this.Controls.Add(this.SmallPaddle);
            this.Controls.Add(this.P2Point);
            this.Controls.Add(this.P1Point);
            this.Controls.Add(this.BorderRight);
            this.Controls.Add(this.BorderLeft);
            this.Controls.Add(this.BorderUp);
            this.Controls.Add(this.BorderDown);
            this.Controls.Add(this.Paddle2);
            this.Controls.Add(this.Paddle1);
            this.Controls.Add(this.imgBall);
            this.Controls.Add(this.Finisher);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2 Players";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finisher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddleFast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Invisiball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBall;
        private System.Windows.Forms.PictureBox Paddle1;
        private System.Windows.Forms.PictureBox Paddle2;
        private System.Windows.Forms.Timer atimer;
        private System.Windows.Forms.PictureBox BorderDown;
        private System.Windows.Forms.PictureBox BorderUp;
        private System.Windows.Forms.PictureBox BorderLeft;
        private System.Windows.Forms.PictureBox BorderRight;
        private System.Windows.Forms.Label P1Point;
        private System.Windows.Forms.Label P2Point;
        private System.Windows.Forms.PictureBox Finisher;
        private System.Windows.Forms.PictureBox SmallPaddle;
        private System.Windows.Forms.PictureBox PaddleFast;
        private System.Windows.Forms.PictureBox Invisiball;
        private System.Windows.Forms.Timer endgameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}