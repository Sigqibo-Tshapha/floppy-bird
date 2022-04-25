using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdProject
{
    public partial class Form : System.Windows.Forms.Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;

        public Form()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            floppyBird.Top += gravity;
            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;
            ground.Left -= pipeSpeed;
            ground2.Left -= pipeSpeed;
            scoreText.Text = "Score : " + score;

            if(ground.Left< -750)
            {
                ground.Left = 500;
            }
            if (ground2.Left < -750)
            {
                ground2.Left = 500;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left =950;
                score++;
            }
            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            
            if(score>10 )
            { 
                pipeSpeed = 12 ;
            }
            
            if (floppyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || floppyBird.Bounds.IntersectsWith(pipeTop.Bounds) || 
                floppyBird.Top >= 424 || floppyBird.Top<-5)
            {
                endGame();
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
                
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void gameKeyIsOther(object sender, KeyPressEventArgs e)
        {

        }

        private void ground_Click(object sender, EventArgs e)
        {

        }
        private void endGame()
        {
            gameTimer.Stop();
            finalScoreTxt.Text = "Final Score: " + score;
            scoreText.Visible = false;  
            gameOverBox.Visible = true;

        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Show();
            this.Hide();

        }
    }
}
