using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotPotatoPong
{
    public class Ball {
        private PictureBox ball;
        PictureBox  BorderLeft, BorderRight/* paddlespeedboost*/;
        Random rand = new Random();
        Player PlayerOne, PlayerTwo;
       public int xSpeed, ySpeed;
        PictureBox imgBall;




        public Ball(PictureBox imgBall, 
            Player PlayerOne, Player PlayerTwo, PictureBox BorderLeft, PictureBox BorderRight/*, PictureBox paddleboost*/)
        {
            this.ball = imgBall;
            this.BorderLeft = BorderLeft;
            this.BorderRight = BorderRight;
            this.PlayerOne = PlayerOne;
            this.PlayerTwo = PlayerTwo;
            //this.paddlespeedboost = paddleboost;
          


            xSpeed = 10;
            ySpeed = 3;
            ResetBall();
        

        }



        internal  void ProcessMove() {
           

            ball.Location = new Point(ball.Location.X + xSpeed, 
                Math.Max(Border.TopWorld, Math.Min(Border.BottomWorld, ball.Location.Y + ySpeed)));

            if (ball.Location.Y == Border.TopWorld || ball.Location.Y == Border.BottomWorld) {
                ySpeed *= -1;
                

            }

            if (ball.Bounds.IntersectsWith(BorderLeft.Bounds)) {
                Score(PlayerTwo);
               

            }
            else if (ball.Bounds.IntersectsWith(BorderRight.Bounds)) {
                Score(PlayerOne);
               


            }

            if (PlayerOne.paddle.Bounds.IntersectsWith(ball.Bounds)
                || (PlayerTwo.paddle.Bounds.IntersectsWith(ball.Bounds))) {
               
                xSpeed *= -1;
               


                while (PlayerOne.paddle.Bounds.IntersectsWith(ball.Bounds)
                || (PlayerTwo.paddle.Bounds.IntersectsWith(ball.Bounds))) {

                    ball.Location = new Point(ball.Location.X + xSpeed, Math.Max(Border.TopWorld, Math.Min
                        (Border.BottomWorld, ball.Location.Y + ySpeed)));

                }
            }


        }

       

        private  void Score(Player winningPlayer)
        {
            
            winningPlayer.score++;
            
            ResetBall();
             

        }

        

        private   void ResetBall()
        {

            

            ball.Location = new Point((Border.LeftWorld + Border.RightWorld) / 2, 
                (Border.TopWorld + Border.BottomWorld) / 2);

           
            if (ball.Location.Y == Border.RightWorld)
                {
                    ySpeed = rand.Next(-3, 3);
                }
                if (ball.Location.Y == Border.LeftWorld)
                {
                    xSpeed = rand.Next(-3, 3);
                }
            
            //do {
            //xSpeed = rand.Next(-3, 3);
            // ySpeed = rand.Next(-3,3);
            //} while (Math.Abs(xSpeed)+Math.Abs(ySpeed)<=2 || Math.Abs(xSpeed) <= 1);
        }
    }
}
