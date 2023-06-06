using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotPotatoPong
{
    public class Player
    {
       public PictureBox paddle;
        Label scoreLabel;

        int _score;
        public int score { 

        get {
                return _score;
            }

        set {
                _score = value;
                scoreLabel.Text = score.ToString();


            }
         }


        public Player(PictureBox Paddle1, Label scoreLabel)
        {
            this.paddle = Paddle1;
            
            this.scoreLabel = scoreLabel;


        }
       
}
}
