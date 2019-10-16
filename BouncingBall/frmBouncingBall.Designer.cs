namespace BouncingBall
{
    partial class frmBouncingBall
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
            this.pnl = new System.Windows.Forms.Panel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.lblBounces = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtVelocity = new System.Windows.Forms.TextBox();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.Black;
            this.pnl.Controls.Add(this.lblNotes);
            this.pnl.Controls.Add(this.pic);
            this.pnl.Controls.Add(this.lblBounces);
            this.pnl.Location = new System.Drawing.Point(12, 12);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(300, 300);
            this.pnl.TabIndex = 0;
            this.pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Paint);
            this.pnl.MouseEnter += new System.EventHandler(this.pnl_MouseEnter);
            this.pnl.MouseLeave += new System.EventHandler(this.pnl_MouseLeave);
            // 
            // lblNotes
            // 
            this.lblNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.Yellow;
            this.lblNotes.Location = new System.Drawing.Point(64, 167);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(173, 56);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.Visible = false;
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(95, 74);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(90, 90);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Visible = false;
            // 
            // lblBounces
            // 
            this.lblBounces.AutoSize = true;
            this.lblBounces.ForeColor = System.Drawing.Color.Yellow;
            this.lblBounces.Location = new System.Drawing.Point(202, 11);
            this.lblBounces.Name = "lblBounces";
            this.lblBounces.Size = new System.Drawing.Size(57, 13);
            this.lblBounces.TabIndex = 0;
            this.lblBounces.Text = "Bounces : ";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Blue;
            this.btnNewGame.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewGame.Location = new System.Drawing.Point(341, 38);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(107, 32);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Red;
            this.btnPause.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnPause.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPause.Location = new System.Drawing.Point(341, 86);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(107, 32);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.DarkGreen;
            this.btnResume.Enabled = false;
            this.btnResume.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnResume.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResume.Location = new System.Drawing.Point(341, 130);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(107, 32);
            this.btnResume.TabIndex = 3;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtVelocity
            // 
            this.txtVelocity.Location = new System.Drawing.Point(487, 200);
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.Size = new System.Drawing.Size(100, 20);
            this.txtVelocity.TabIndex = 4;
            this.txtVelocity.Text = "0.5";
            this.txtVelocity.Visible = false;
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.Location = new System.Drawing.Point(484, 184);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(44, 13);
            this.lblVelocity.TabIndex = 5;
            this.lblVelocity.Text = "Velocity";
            this.lblVelocity.Visible = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::BouncingBall.Properties.Resources.Cool_Text_336681621015321;
            this.Logo.Location = new System.Drawing.Point(-79, 325);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(618, 200);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // frmBouncingBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.lblVelocity);
            this.Controls.Add(this.txtVelocity);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pnl);
            this.Name = "frmBouncingBall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bouncing ball";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label lblBounces;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtVelocity;
        private System.Windows.Forms.Label lblVelocity;
        private System.Windows.Forms.PictureBox Logo;
    }
}

