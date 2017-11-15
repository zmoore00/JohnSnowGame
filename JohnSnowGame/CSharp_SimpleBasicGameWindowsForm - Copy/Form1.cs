using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Zackary Moore
//Avery Haynes
namespace CSharp_SimpleBasicGameWindowsForm
{
    public partial class Form1 : Form
    {
        //This is used to control how fast John Snow moves.  Increase it and he will move accross the screen faster
        //Maybe we have another item on the screen and if John Snow picks it up he moves faster for a period of time
        const int mainCharacterSpeed = 7;

        //The booleans listed below handle if John Snow is moving at a diagonal
        bool up = false;
        bool down = false;
        bool left = false;
        bool right = false;

        bool up2 = false;
        bool down2 = false;
        bool left2 = false;
        bool right2 = false;

        //These booleans are used to tell me which direction the fire is moving.  I use this so once it reaches the end of the frame I can send it back the other way
        //Almost as if it bounced off the wall
        bool fireLeft = false;
        bool fire1Left = true;
        bool fire2Left = false;
        bool fire3Left = true;

        //Used to store John Snow's current x and y position on the frame
        int johnPosX;
        int johnPosY;

        //Used to store the fires x postion on the frame
        int firePosX;

        //Used to tell me if the game is paused or not.  This was some weird idea I came up with.  The pause referes to time, not actually pausing the game.
        //I am treating paused time as a sort of special ability.  It allows John Snow to walk through walls
        bool paused = false;

        //This is used to tell the game how long I can pause time\
        int pausedTimerCount = 5;

        int coinSide = 0;

        public Form1()
        {
            InitializeComponent();
            //This is so I can get the x position of the fire.
            firePosX = fire.Left;

            //This was a test.  I was doing this becuase I was going to have John Snow walk towards the fire.  Once he got within a specific range of the fire I would make it start moving.
            //This works, you just have to uncomment out this block of code
            //fireTimer = new Timer();
            //fireTimer.Start();
            //fire.Visible = false;
            //fire1.Visible = false;
            //fire2.Visible = false;
            //fire3.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //This is used to handle pessing the up key
            if(e.KeyCode == Keys.Up)
            {
                //If time is paused I am allowing John Snow to walk off the board and appear on the other side
                if (!paused)
                {
                    //This is making sure that I am only allowing John Snow to move if is Top position (Y coordinates) are greater than 0
                    //less than 0 means he is going to go out of frame
                    if (JohnSnow.Top >= 0)
                    {
                        JohnSnow.Top -= mainCharacterSpeed;
                        johnPosY = JohnSnow.Top;
                    }
                }
                //If time is not paused John Snow is stuck with the constraints of the board
                else
                {
                    JohnSnow.Top -= mainCharacterSpeed;
                    johnPosY = JohnSnow.Top;
                }
                //Boolean used to hand diagonal movement
                up = true;  
            }

            //This is used to handle pessing the down key
            if (e.KeyCode == Keys.Down)
            {
                //If time is paused I am allowing John Snow to walk off the board and appear on the other side
                if (!paused)
                {
                    //This is making sure that I am only allowing John Snow to move if is Top position (Y coordinates) are less than frame height - 150
                    //greater than this.Height means he is going to go out of frame
                    //Why am I subtracting 150.  Becuase the way that this game is setup it is possible that the timing could be a little bit off and allow the user to walk out of 
                    //fram before this check happens.  This is not a good way to do this becuase 150 is static. THAT IS BAD!
                    if (JohnSnow.Top <= this.Height - 150)
                    {
                        JohnSnow.Top += mainCharacterSpeed;
                        johnPosY = JohnSnow.Top;
                    }
                }
                //If time is not paused John Snow is stuck with the constraints of the board
                else
                {
                    JohnSnow.Top += mainCharacterSpeed;
                    johnPosY = JohnSnow.Top;
                }
                //Boolean used to hand diagonal movement
                down = true;
                
            }

            //This is used to handle pessing the left key
            if (e.KeyCode == Keys.Left)
            {
                //If time is paused I am allowing John Snow to walk off the board and appear on the other side
                if (!paused)
                {
                    //This is making sure that I am only allowing John Snow to move if is Left position (X coordinates) are greater than 0
                    //less than 0 means he is going to go out of frame
                    if (JohnSnow.Left >= 0)
                    {
                        JohnSnow.Left -= mainCharacterSpeed;
                        //If he is moving to the left I want my character to face the left.  So change the image
                        JohnSnow.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.newJohnSnow;
                    }
                }
                //If time is not paused John Snow is stuck with the constraints of the board
                else
                {
                    JohnSnow.Left -= mainCharacterSpeed;
                    //If he is moving to the left I want my character to face the left.  So change the image
                    JohnSnow.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.newJohnSnow;
                }
                //Boolean used to hand diagonal movement

                left = true;
                johnPosX = JohnSnow.Left;
            }

            //This is used to handle pessing the right key
            if (e.KeyCode == Keys.Right)
            {
                //If time is paused I am allowing John Snow to walk off the board and appear on the other side
                if (!paused)
                {
                    //This is making sure that I am only allowing John Snow to move if is Left position (X coordinates) are less than frame height - 120
                    //greater than this.Width means he is going to go out of frame
                    //Why am I subtracting 120.  Becuase the way that this game is setup it is possible that the timing could be a little bit off and allow the user to walk out of 
                    //fram before this check happens.  This is not a good way to do this becuase 120 is static. THAT IS BAD!
                    if (JohnSnow.Left <= this.Width - 120)
                    {
                        JohnSnow.Left += mainCharacterSpeed;
                        //If he is moving to the right I want my character to face the right.  So change the image
                        JohnSnow.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.newJohnSnowFaceRight;
                    }
                }
                //If time is not paused John Snow is stuck with the constraints of the board
                else
                {
                    JohnSnow.Left += mainCharacterSpeed;
                    //If he is moving to the right I want my character to face the right.  So change the image
                    JohnSnow.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.newJohnSnowFaceRight;
                }
                //Boolean used to hand diagonal movement
                right = true;
                johnPosX = JohnSnow.Left;
            }
            //===============================================================================================================
            //                                                   ASD
            //===============================================================================================================
            if (e.KeyCode == Keys.W)
            {

                if (!paused)
                {

                    if (JohnSnow.Top >= 0)
                    {
                        JohnSnow.Top -= mainCharacterSpeed;
                        johnPosY = JohnSnow.Top;
                    }
                }
                else
                {
                    JohnSnow.Top -= mainCharacterSpeed;
                    johnPosY = JohnSnow.Top;
                }
                up = true;
            }

            if (e.KeyCode == Keys.S)
            {
                if (!paused)
                {
                    if (JohnSnow.Top <= this.Height - 150)
                    {
                        JohnSnow.Top += mainCharacterSpeed;
                        johnPosY = JohnSnow.Top;
                    }
                }
                else
                {
                    JohnSnow.Top += mainCharacterSpeed;
                    johnPosY = JohnSnow.Top;
                }
                down = true;

            }

            if (e.KeyCode == Keys.A)
            {
                if (!paused)
                {
                    if (JohnSnow.Left >= 0)
                    {
                        JohnSnow.Left -= mainCharacterSpeed;
                        JohnSnow.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.newJohnSnow;
                    }
                }
                else
                {
                    JohnSnow.Left -= mainCharacterSpeed;
                    JohnSnow.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.newJohnSnow;
                }

                left = true;
                johnPosX = JohnSnow.Left;
            }

            if (e.KeyCode == Keys.D)
            {
                if (!paused)
                {
                    if (JohnSnow.Left <= this.Width - 120)
                    {
                        JohnSnow.Left += mainCharacterSpeed;
                        JohnSnow.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.newJohnSnowFaceRight;
                    }
                }
                else
                {
                    JohnSnow.Left += mainCharacterSpeed;
                    JohnSnow.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.newJohnSnowFaceRight;
                }
                right = true;
                johnPosX = JohnSnow.Left;
            }
            if (e.KeyCode == Keys.W && e.KeyCode == Keys.D)
            {
                JohnSnow.Top -= mainCharacterSpeed;
                JohnSnow.Left += mainCharacterSpeed;
            }

            //Space bar is how I am going to have John Snow pause time
            if(e.KeyCode == Keys.Space)
            {
                //If I hit space and time is not already paused then I want to pause it
                if (!paused)
                {
                    //Pause time set to true so we can use this check in other if statements
                    paused = true;
                    //Start the timer.  I am only allowing John Snow to pause time for 5 seconds
                    pausedTimer.Enabled = true;

                }
                //If time is already paused and I hit space I want to un-pause time
                else
                {
                    //paused set to false for other if statment checks
                    paused = false;
                    //Stop the timer
                    pausedTimer.Enabled = false;
                }
            }


            //function to move main character
            //This is where I am handling if the character is moving diagonal
            moveMainCharacter();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false; 
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
        }
        private void Form1_KeyUp2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up2 = false;
            }
            if (e.KeyCode == Keys.S)
            {
                down2 = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left2 = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right2 = false;
            }
        }

        private void moveMainCharacter()
        {
            if (up && right)
            {
                JohnSnow.Top -= mainCharacterSpeed;
                JohnSnow.Left += mainCharacterSpeed;

                johnPosX = JohnSnow.Left;
                johnPosY = JohnSnow.Top;
            }
            if (up && left)
            {
                JohnSnow.Top -= mainCharacterSpeed;
                JohnSnow.Left -= mainCharacterSpeed;

                johnPosX = JohnSnow.Left;
                johnPosY = JohnSnow.Top;
            }
            if (down && right)
            {
                JohnSnow.Top += mainCharacterSpeed;
                JohnSnow.Left += mainCharacterSpeed;

                johnPosX = JohnSnow.Left;
                johnPosY = JohnSnow.Top;
            }
            if (down && left)
            {
                JohnSnow.Top += mainCharacterSpeed;
                JohnSnow.Left -= mainCharacterSpeed;

                johnPosX = JohnSnow.Left;
                johnPosY = JohnSnow.Top;
            }
        }
                    private void moveMainCharacter2()
        {
            if (up2 && right2)
            {
                JohnSnow.Top -= mainCharacterSpeed;
                JohnSnow.Left += mainCharacterSpeed;

                johnPosX = JohnSnow.Left;
                johnPosY = JohnSnow.Top;
            }
            if (up2 && left2)
            {
                JohnSnow.Top -= mainCharacterSpeed;
                JohnSnow.Left -= mainCharacterSpeed;

                johnPosX = JohnSnow.Left;
                johnPosY = JohnSnow.Top;
            }
            if (down2 && right2)
            {
                JohnSnow.Top += mainCharacterSpeed;
                JohnSnow.Left += mainCharacterSpeed;

                johnPosX = JohnSnow.Left;
                johnPosY = JohnSnow.Top;
            }
            if (down2 && left2)
            {
                JohnSnow.Top += mainCharacterSpeed;
                JohnSnow.Left -= mainCharacterSpeed;

                johnPosX = JohnSnow.Left;
                johnPosY = JohnSnow.Top;
            }
            if ((firePosX - johnPosX) < 100)
            {
                fire.Visible = true;
                fire1.Visible = true;
                fire2.Visible = true;
                fire3.Visible = true;
            }
            Console.WriteLine(johnPosX + "    " + johnPosY);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            const int fireSpeed = 10;
            if(fire.Left < 0)
            {
                fireLeft = true;
            }
            else if(fire.Left > this.Width)
            {
                fireLeft = false;
            }
            if (!fireLeft && !paused)
            {
                fire.Left -= fireSpeed;
            }
            else if(fireLeft && !paused)
            {
                fire.Left += fireSpeed;
            }
            //============
            if (fire1.Left < 0)
            {
                fire1Left = true;
            }
            else if (fire1.Left > this.Width)
            {
                fire1Left = false;
            }
            if (!fire1Left && !paused)
            {
                fire1.Left -= fireSpeed;
            }
            else if(fire1Left && !paused)
            {
                fire1.Left += fireSpeed;
            }
            //============
            if (fire2.Left < 0)
            {
                fire2Left = true;
            }
            else if (fire2.Left > this.Width)
            {
                fire2Left = false;
            }
            if (!fire2Left && !paused)
            {
                fire2.Left -= fireSpeed;
            }
            else if(fire2Left && !paused)
            {
                fire2.Left += fireSpeed;
            }

            //Fire LIT
            if (fire3.Left < 0)
            {
                fire3Left = true;
            }
            else if (fire3.Left > this.Width)
            {
                fire3Left = false;
            }
            if (!fire3Left && !paused)
            {
                fire3.Left -= fireSpeed;
            }
            else if(fire3Left && !paused)
            {
                fire3.Left += fireSpeed;
            }

            // Health Bar
            if (fire.Bounds.IntersectsWith(JohnSnow.Bounds))
            {
                //fireTimer.Enabled = false;
                healthBar.Value = healthBar.Value - 5;
                Console.WriteLine("You lose");
            }
            if (fire1.Bounds.IntersectsWith(JohnSnow.Bounds))
            {
                //fireTimer.Enabled = false;
                healthBar.Value = healthBar.Value - 5;
                Console.WriteLine("You lose");
            }
            if (fire2.Bounds.IntersectsWith(JohnSnow.Bounds))
            {
                // fireTimer.Enabled = false;
                healthBar.Value = healthBar.Value - 5;
                Console.WriteLine("You lose");
            }


            // Health Bar
            if (fire3.Bounds.IntersectsWith(JohnSnow.Bounds))
            {
                //fireTimer.Enabled = false;
                healthBar.Value = healthBar.Value - 5;
                Console.WriteLine("You lose");
            }
            if (healthBar.Value < 70)
            {
                healthBar.ForeColor = Color.Orange;
            }
            if(healthBar.Value < 30)
            {
                healthBar.ForeColor = Color.Red;
            }
            if (healthBar.Value == 0)
            {
                fireTimer.Enabled = false;
            }



            // Power
            if(johnPosX <= -91 && paused)
            {
                JohnSnow.Left = this.Width;
            }
            if(johnPosX > this.Width && paused)
            {
                JohnSnow.Left = -91;
            }

            if(johnPosY <= -100 && paused)
            {
                JohnSnow.Top = this.Height;
            }

            if(johnPosY >=  this.Height && paused)
            {
                JohnSnow.Top = -100;
            }
        }

        private void pausedTimer_Tick(object sender, EventArgs e)
        {
            pausedTimerCount--;
            timerDisp.Text = pausedTimerCount.ToString();

            if (pausedTimerCount == 0)
            {
                paused = false;
                pausedTimerCount = 5;
                pausedTimer.Enabled = false;
                timerDisp.Text = pausedTimerCount.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
         
        }

        private void coinTimer_Tick(object sender, EventArgs e)
        {

            if (coinSide == 0)
            {
                coin02.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.coinSide2;
                coinSide++;
            }
            else if (coinSide == 1)
            {
                coin02.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.coinSide3;
                coinSide++;
            }
            else if (coinSide == 2)
            {
                coin02.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.CoinFront1;
                coinSide++;
            }
            else if(coinSide == 3)
            {
                coin02.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.coinSide3;
                coinSide++;
            }
            else if(coinSide == 4)
            {
                coin02.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.coinSide12;
                coinSide = 0;
            }
            
        }
        int mouseX;
        int mouseY;
        //This will handle a mouse click
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //store the click position x in a global variable called mouseX so i can access it in my snowballTimer_Tick method
            mouseX = e.X;
            //store the click position y in a global variable called mouseX so i can access it in my snowballTimer_Tick method
            mouseY = e.Y;
            //enable the timer so it starts running
            snowballTimer.Enabled = true;
        }

        //Global timer so I can tell how many ticks have went by
        int snowballTimeCounter = 0;
        //Global picturebox so i can call it from my snowballTimer_Tick method
        PictureBox snowball;
        private void snowballTimer_Tick(object sender, EventArgs e)
        {
            //First time the timer has ticked
            if (snowballTimeCounter == 0)
            {
                //Create a new picture
                snowball = new PictureBox();
                //Tell the picturebox what image to use
                snowball.Image = CSharp_SimpleBasicGameWindowsForm.Properties.Resources.snowballTest;
                //Have it start on the x cooridate where John is so it appears that he is throwing it.
                snowball.Left = JohnSnow.Left + 90;
                //Have it start on the y cooridate where John is so it appears that he is throwing it.
                snowball.Top = JohnSnow.Top + 30;
                //Add the snowball to the form so we can see it
                this.Controls.Add(snowball);
                //increment counter
                snowballTimeCounter++;
            }
            //second time the timer has ticked
            else if (snowballTimeCounter == 1)
            {
                //move the position of the snowball to where the user clicked
                //The way that this is working is okay but I think it can get alot better.  I would like to see it move accross the screen more than what
                //it does currently.  I will try to fix this in a later update
                snowball.Location = new Point(mouseX, mouseY);
                //increment counter
                snowballTimeCounter++;

            }
            else
            {
                //remove the picturebox from the form
                this.Controls.Remove(snowball);
                //set counter back to 0 so I can do the above if else chain all over again
                snowballTimeCounter = 0;
                //set the timer to false so it does not continue to run this method
                //I only want it to run when the user clicks on the screen
                snowballTimer.Enabled = false;
            }
            
        }
    }
}
