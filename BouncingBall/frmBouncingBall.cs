using Gma.System.MouseKeyHook;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace BouncingBall
{
    public partial class frmBouncingBall : Form
    {
        public frmBouncingBall()
        {
            InitializeComponent();
            baseBounds = new Rectangle(50, 50, 50, 15);
            ballBounds = new Rectangle(0, 0, 25, 25);
            Subscribe();
        }

        #region Members area :-

        private SoundPlayer player = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "/bounce.wav");
        private SoundPlayer player_suc = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "/applause.wav");

        private Rectangle baseBounds, ballBounds;

        private Graphics graph;

        private IKeyboardMouseEvents m_GlobalHook;

        private bool dirRight = true, dirDown = true;

        private double velocity = 0, old_velocity = 0;

        private double g = 0.5;

        private int el_X = 0, el_Y = 0, limitX = 0;

        private int bounce = 0;

        #endregion

        #region Main Functions area :-
        private void moveBall()
        {
            if (dirRight) // Move the ball to the right
            {
                el_X += 5;

                if (el_X >= pnl.Width - 50) // If the position of the ball reaches the right limit of the window then go to th left
                {
                    dirRight = false;
                }
            }
            else
            {// Move the ball to the left
                el_X -= 5;

                if (el_X <= 5)// If the position of the ball reaches the left limit of the window then go to th right
                    dirRight = true;
            }

            if (dirDown) // Move the ball down
            {
                velocity = velocity + g; // The velocity of the ball while going down

                if (velocity == old_velocity) // The ball has lost its velocity and no more bounces will take place
                {
                    // The game is finished /////////////// YOU WIN /////////////////////////////
                    timer.Stop();
                    pic.Visible = true;
                    lblNotes.Visible = true;
                    player_suc.Play();
                    pic.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/win.png");
                    lblNotes.Text = "You are good at this. " + bounce + " bounces.";

                    btnResume.Enabled = false;
                    btnPause.Enabled = false;
                    return;
                }

                el_Y = (el_Y + Convert.ToInt32(velocity)) + Convert.ToInt32(0.5 * g); // Increase the vertical position of the ball gradually

                if (el_Y >= pnl.Height - 82) // If the ball reaches the bottom limit of the window
                {
                    if (el_X + 25 >= limitX && el_X <= (limitX + 50)) // Check if the ball hits the rectangle and pops up again
                    {
                        old_velocity = velocity;
                        dirDown = false;
                        bounce++;
                        lblBounces.Text = "Bounce: " + bounce;
                        player.Play();
                    }
                    else
                    { // The ball didn't hit the rectangle and you loose
                        timer.Stop();
                        pic.Visible = true;
                        lblNotes.Visible = true;
                        pic.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/loose.png");
                        lblNotes.Text = "Ohh...please try again.";

                        btnResume.Enabled = false;
                        btnPause.Enabled = false;
                    }
                }
            }
            else
            {// The direction is UP now
                velocity = velocity - g; // The velocity of the ball will decrease until it reaches zero

                el_Y = (el_Y - Convert.ToInt32(velocity)) - Convert.ToInt32(0.5 * g);

                if (velocity <= 0) // The velocity now is zero or less so go down again
                {
                    velocity = 0;
                    dirDown = true;
                }
            }

            drawEllipse(el_X, el_Y); // Draw the ball with its new location on the screen
            pnl.Invalidate();
        }

        private void drawMyRect(int x, int y)
        {
            if ((x + 70) >= pnl.Width)
                x = pnl.Width - 70;

            if ((x) <= 5)
                x = 5;

            limitX = x;
            baseBounds.Location = new Point(x, pnl.Height - 55);
        }

        private void drawEllipse(int el_X, int el_Y)
        {
            ballBounds.Location = new Point(el_X, el_Y);
        }

        #endregion

        #region Main events area :-

        public void Subscribe()
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseMove += M_GlobalHook_MouseMove;
        }

        private void M_GlobalHook_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= (this.DesktopLocation.X) && e.X <= (this.DesktopLocation.X + this.Width))
            {
                var relativePoint = this.PointToClient(Cursor.Position);
                drawMyRect(relativePoint.X, e.Y);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            moveBall();
        }

        private void pnl_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void pnl_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            dirRight = true;
            dirDown = true;
            el_Y = 0;
            velocity = 0;
            old_velocity = 0;
            bounce = 0;
            pic.Visible = false;
            lblNotes.Visible = false;
            pic.Image = null;
            lblBounces.Text = "";
            timer.Start();

            btnResume.Enabled = false;
            btnPause.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnResume.Enabled = true;
            btnPause.Enabled = false;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            timer.Start();
            btnResume.Enabled = false;
            btnPause.Enabled = true;
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {
            graph = e.Graphics;
            graph.FillRectangle(Brushes.Yellow, baseBounds);
            graph.FillEllipse(Brushes.Red, ballBounds);
        }

        #endregion

    }
}
