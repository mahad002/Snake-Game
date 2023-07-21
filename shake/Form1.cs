using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shake.Properties;

namespace shake
{
    public partial class Form1 : Form
    {
        private List<SnakeBody> Snake = new List<SnakeBody>();
        private SnakeBody food = new SnakeBody();
        int maxWidth;
        int maxHeight;
        int score;
        int highScore=0;
        Random rand = new Random();
        bool goLeft, goRight, goDown, goUp;
        public Form1()
        {
            InitializeComponent();
            new Game();
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Game.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Game.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Game.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Game.directions != "up")
            {
                goDown = true;
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }
        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }
      
        private void GameTimerEvent(object sender, EventArgs e)
        {
            // setting the directions
            if (goLeft)
            {
                Game.directions = "left";
            }
            if (goRight)
            {
                Game.directions = "right";
            }
            if (goDown)
            {
                Game.directions = "down";
            }
            if (goUp)
            {
                Game.directions = "up";
            }
            // end of directions
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Game.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            picCanvas.Invalidate();
        }
        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColour;
            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.LightBlue;
                }
                else
                {
                    snakeColour = Brushes.DarkBlue;
                }
                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Game.Width,
                    Snake[i].Y * Game.Height,
                    Game.Width, Game.Height
                    ));
            }
            canvas.FillEllipse(Brushes.Black, new Rectangle
            (
            food.X * Game.Width,
            food.Y * Game.Height,
            Game.Width, Game.Height
            ));
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            namebox.Enabled = false;
            StartGame(sender,e);
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            UpdatePictureBoxGraphics(sender,e);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            GameTimerEvent(sender, e);
            for(int i=0;i<Snake.Count;i++)
            {
                Console.WriteLine(Snake[i].X);
                Console.WriteLine(Snake[i].Y);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyIsDown(sender, e);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            KeyIsUp(sender, e);
        }

        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Game.Width - 1;
            maxHeight = picCanvas.Height / Game.Height - 1;
            Snake.Clear();
            Start.Enabled = false;
            score = 0;
            ScoreLabel.Text = "Score: " + score;
            SnakeBody head = new SnakeBody { X = 10, Y = 5 };
            Snake.Add(head); // adding the head part of the snake to the list
            for (int i = 0; i < 5; i++)
            {
                SnakeBody body = new SnakeBody();
                Snake.Add(body);
            }
            food = new SnakeBody { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            gameTimer.Start();
        }
        private void EatFood()
        {
            score += 1;
            ScoreLabel.Text = "Score: " + score;
            SnakeBody body = new SnakeBody
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(body);
            food = new SnakeBody { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }
        private void GameOver()
        {
            gameTimer.Stop();
            namebox.Enabled = true;
            Start.Enabled = true;
            if(score>highScore)
            {
                highScore = score;
                HScoreLabel.Text = "High Score: " + highScore;
                MessageBox.Show("Congratulations "+ namebox.Text+ " you have a new highscore");
            }
            
        }
           
           
    }
}
