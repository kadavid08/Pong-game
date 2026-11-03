using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        int playerScore = 0;
        int computerScore = 0;
        int ballX = 6;
        int ballY = 4;
        bool moveUp = false;
        bool moveDown = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            playerScore = 0;
            computerScore = 0;
            scoreLabel.Text = "0 : 0";
            statusLabel.Text = "First to 5 points wins!";
            startButton.Text = "RESTART";
            moveUp = false;
            moveDown = false;

            player.Top = (field.ClientSize.Height - player.Height) / 2;
            computer.Top = (field.ClientSize.Height - computer.Height) / 2;
            ballX = 6;
            ballY = 4;
            ResetBall();
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Move the player while W or S is held down.
            if (moveUp)
                player.Top -= 8;
            if (moveDown)
                player.Top += 8;

            // The computer slowly follows the middle of the ball.
            int ballMiddle = ball.Top + ball.Height / 2;
            int computerMiddle = computer.Top + computer.Height / 2;

            if (ballMiddle < computerMiddle - 3)
                computer.Top -= 3;
            if (ballMiddle > computerMiddle + 3)
                computer.Top += 3;

            KeepInside(player);
            KeepInside(computer);

            ball.Left += ballX;
            ball.Top += ballY;

            // Bounce off the top and bottom walls.
            if (ball.Top <= 0)
            {
                ball.Top = 0;
                ballY = -ballY;
            }
            if (ball.Bottom >= field.ClientSize.Height)
            {
                ball.Top = field.ClientSize.Height - ball.Height;
                ballY = -ballY;
            }

            // Only bounce when moving towards the paddle.
            if (ballX < 0 && ball.Bounds.IntersectsWith(player.Bounds))
            {
                ball.Left = player.Right;
                ballX = -ballX;
            }
            if (ballX > 0 && ball.Bounds.IntersectsWith(computer.Bounds))
            {
                ball.Left = computer.Left - ball.Width;
                ballX = -ballX;
            }

            // Give a point when the whole ball leaves the field.
            if (ball.Right < 0)
            {
                computerScore++;
                FinishPoint();
            }
            else if (ball.Left > field.ClientSize.Width)
            {
                playerScore++;
                FinishPoint();
            }
        }

        private void KeepInside(Panel paddle)
        {
            if (paddle.Top < 0)
                paddle.Top = 0;
            if (paddle.Bottom > field.ClientSize.Height)
                paddle.Top = field.ClientSize.Height - paddle.Height;
        }

        private void ResetBall()
        {
            ball.Left = (field.ClientSize.Width - ball.Width) / 2;
            ball.Top = (field.ClientSize.Height - ball.Height) / 2;
        }

        private void FinishPoint()
        {
            scoreLabel.Text = playerScore + " : " + computerScore;
            ballX = -ballX;
            ResetBall();

            if (playerScore == 5 || computerScore == 5)
            {
                gameTimer.Stop();

                if (playerScore == 5)
                    statusLabel.Text = "YOU WIN! Click Restart to play again.";
                else
                    statusLabel.Text = "AI WINS! Click Restart to try again.";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                moveUp = true;
            if (e.KeyCode == Keys.S)
                moveDown = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                moveUp = false;
            if (e.KeyCode == Keys.S)
                moveDown = false;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            // Avoid stuck movement after switching to another window.
            moveUp = false;
            moveDown = false;
        }
    }
}
