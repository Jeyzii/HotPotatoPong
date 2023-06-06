using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotPotatoPong {
    public partial class elmo: Form {
        bool isUpPressed, isDownPressed, isUpPressed2, isDownPressed2;
        public int PaddleMS = 3;
        int Top = 53, Bottom = 389, rando = 0;
        Player player1, player2;
        // Main form;

        Ball ball;
        Size Smallsize = new Size(18, 60);
        Size Bigsize = new Size(18, 128);


        public elmo() {
            InitializeComponent();
            player1 = new Player(Paddle1, P1Point);
            player2 = new Player(Paddle2, P2Point);
            ball = new Ball(imgBall, player1, player2, BorderLeft, BorderRight/*,paddlespeedboost*/);

            PictureBox[] powerups = { PaddleFast, Invisiball, SmallPaddle };
            // powerups[0]=PaddleFast;
            //  powerups[1]=Invisiball;
            // powerups[2]=SmallPaddle;


            fastpaddle();
            paddlesmall();
            visibleBall();
        }

        Random rnd1 = new Random();

        void fastpaddle()
        {

            int x = rnd1.Next(20, 930);
            int y = rnd1.Next(50, 490);

            PaddleFast.Location = new Point(x, y);


        }

        public async void fastpaddle2()
        {
            PaddleFast.Visible = false;
            PaddleFast.Enabled = false;
            await Task.Delay(11000);
            PaddleFast.Visible = true;
            PaddleFast.Enabled = true;
        }

        private async void paddlesmall()
        {

            int q = rnd1.Next(20, 930);
            int r = rnd1.Next(50, 490);

            SmallPaddle.Location = new Point(q, r);
        }

        private async void paddlesmall2()
        {

            SmallPaddle.Visible = false;
            SmallPaddle.Enabled = false;
            await Task.Delay(11000);
            SmallPaddle.Visible = true;
            SmallPaddle.Enabled = true;
        }

        private async void ballinvisi()
        {

            int w = rnd1.Next(20, 930);
            int s = rnd1.Next(50, 490);

            Invisiball.Location = new Point(w, s);

        }


        //elmo
        void endgame()
        {
            int j = 503;
            int r = 343;

            Finisher.Location = new Point(j, r);
            nextloc();

        }
        //lipat elmo
        private async void nextloc()
        {

            await Task.Delay(30000);
            int j = 334;
            int r = 325;

            Finisher.Location = new Point(j, r);
            await Task.Delay(5000);
            int q = 390;
            int w = 253;

            Finisher.Location = new Point(q, w);
            await Task.Delay(5000);
            int e = 494;
            int t = 212;

            Finisher.Location = new Point(e, t);
            await Task.Delay(5000);
            int u = 298;
            int i = 6;

            Finisher.Location = new Point(u, i);
        }

      


        //paddle back ms method
        private async void PaddleBackMS()
        {

            await Task.Delay(10000);
            PaddleMS = 3;
        }

        //endgame timer
        private void endgameTimer_Tick(object sender, EventArgs e)
        {
            endgame();
            Finisher.Visible = true;
        }

        private void elmo_Load(object sender, EventArgs e)
        {

        }
       

        //ball balik mthod
        private async void visibleBall()
        {

            await Task.Delay(2000);
            imgBall.Visible = true;
        }
        //paddlebacksize method
        private async void PaddleBackSize()
        {

            await Task.Delay(10000);

            Paddle2.Size = Bigsize;
            Paddle1.Size = Bigsize;
            Bottom = 389;

        }
        //end game
        private async void finishna()
        {

            await Task.Delay(100000);
        }


        private void atimer_Tick(object sender, EventArgs e)
        {
            ball.ProcessMove();
            // Random indexes = new Random();
            // rando=indexes.Next(0,3);


            //ball invisible
            if (Invisiball.Bounds.IntersectsWith(imgBall.Bounds))
            {
                imgBall.Visible = false;

                ballinvisi();


            }
            //endgame
            if (Finisher.Bounds.IntersectsWith(imgBall.Bounds))
            {
                finishna();

                atimer.Stop();
                MessageBox.Show("NOBODY WINS! EVERYONE LOSES!!!");
                this.Close();
                ContinueStop go = new ContinueStop();
                go.Show();

            }
            //ball visible
            if (imgBall.Visible == false)
            {
                visibleBall();
            }


            //paddle bilis
            if (PaddleFast.Bounds.IntersectsWith(imgBall.Bounds))
            {
                PaddleMS += 2;
                fastpaddle2();
                fastpaddle();

            }


            //balik paddle bilis
            if (PaddleMS == 5)
            {
                PaddleBackMS();
            }


            //paliitin paddle
            if (SmallPaddle.Bounds.IntersectsWith(imgBall.Bounds))
            {

                Paddle2.Size = Smallsize;
                Paddle1.Size = Smallsize;
                Bottom = 457;
                paddlesmall2();
                paddlesmall();





            }
            //paddle balik normal
            if ((Paddle1.Size == Smallsize) || (Paddle2.Size == Smallsize))
            {

                PaddleBackSize();
            }




            if (player1.score == 10)
            {

                atimer.Stop();
                MessageBox.Show("P1 Winner");
                this.Close();
                ContinueStop1p go = new ContinueStop1p();
                go.Show();


            }
            if (player2.score == 10)
            {
                atimer.Stop();
                MessageBox.Show("P2 Winner");
                this.Close();
                ContinueStop1p go = new ContinueStop1p();
                go.Show();

            }





            if (isUpPressed)
            {
                Paddle1.Location = new Point(Paddle1.Location.X, Math.Max(Top, Paddle1.Location.Y - PaddleMS));
            }
            if (isDownPressed)
            {
                Paddle1.Location = new Point(Paddle1.Location.X, Math.Min(Bottom, Paddle1.Location.Y + PaddleMS));
            }
            if (isUpPressed2)
            {

                Paddle2.Location = new Point(Paddle2.Location.X, Math.Max(Top, Paddle2.Location.Y - PaddleMS));
            }
            if (isDownPressed2)
            {
                Paddle2.Location = new Point(Paddle2.Location.X, Math.Min(Bottom, Paddle2.Location.Y + PaddleMS));
            }
        }
        private void elmo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    isUpPressed = true;
                    isUpPressed2 = true;
                    break;
                case Keys.S:
                    isDownPressed = true;
                    isDownPressed2 = true;
                    break;

                case Keys.Up:
                    isUpPressed = true;
                    isUpPressed2 = true;
                    break;
                case Keys.Down:
                    isDownPressed = true;
                    isDownPressed2 = true;
                    break;

            }
        }

        private void elmo_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    isUpPressed = false;
                    isUpPressed2 = false;
                    break;
                case Keys.S:
                    isDownPressed = false;
                    isDownPressed2 = false;
                    break;

                case Keys.Up:
                    isUpPressed = false;
                    isUpPressed2 = false;
                    break;
                case Keys.Down:
                    isDownPressed = false;
                    isDownPressed2= false;
                    break;

            }
        }

    }
}
