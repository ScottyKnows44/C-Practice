using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score : " + score;

       

            if (pipeBottom.Left < -100){
                int newSpot = getRandomPlace();
                pipeBottom.Left = newSpot;
                score++;
            }

            if (pipeTop.Left < -80) {
                int newSpot = getRandomPlace();
                pipeTop.Left = newSpot;
                score++;
            }

            if(flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();    
            }
           
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }

        private void endGame(){
            gameTimer.Stop();
            scoreText.Text += " Game Over!";
            score = 0;
        }

        private int getRandomPlace()
        {
            var random = new Random();
            int number = random.Next(800, 1500);
            return number;
        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }
    }
}
