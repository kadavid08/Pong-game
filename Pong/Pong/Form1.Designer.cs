namespace Pong
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.field = new System.Windows.Forms.Panel();
            this.centerLine = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.Panel();
            this.computer = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.goalLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.field.SuspendLayout();
            this.SuspendLayout();
            //
            // field
            //
            this.field.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field.Location = new System.Drawing.Point(20, 115);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(760, 340);
            this.field.Controls.Add(this.ball);
            this.field.Controls.Add(this.player);
            this.field.Controls.Add(this.computer);
            this.field.Controls.Add(this.centerLine);
            //
            // centerLine
            //
            this.centerLine.BackColor = System.Drawing.Color.FromArgb(44, 55, 76);
            this.centerLine.Location = new System.Drawing.Point(378, 0);
            this.centerLine.Name = "centerLine";
            this.centerLine.Size = new System.Drawing.Size(2, 338);
            //
            // player
            //
            this.player.BackColor = System.Drawing.Color.FromArgb(34, 211, 238);
            this.player.Location = new System.Drawing.Point(22, 131);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(14, 76);
            //
            // computer
            //
            this.computer.BackColor = System.Drawing.Color.FromArgb(251, 146, 60);
            this.computer.Location = new System.Drawing.Point(722, 131);
            this.computer.Name = "computer";
            this.computer.Size = new System.Drawing.Size(14, 76);
            //
            // ball
            //
            this.ball.BackColor = System.Drawing.Color.FromArgb(250, 204, 21);
            this.ball.Location = new System.Drawing.Point(372, 162);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 14);
            //
            // titleLabel
            //
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(18, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(210, 46);
            this.titleLabel.Text = "PONG";
            //
            // goalLabel
            //
            this.goalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.goalLabel.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.goalLabel.Location = new System.Drawing.Point(600, 28);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(180, 25);
            this.goalLabel.Text = "FIRST TO 5";
            this.goalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // scoreLabel
            //
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.scoreLabel.Location = new System.Drawing.Point(310, 52);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(180, 55);
            this.scoreLabel.Text = "0 : 0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // playerLabel
            //
            this.playerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.playerLabel.ForeColor = System.Drawing.Color.FromArgb(34, 211, 238);
            this.playerLabel.Location = new System.Drawing.Point(170, 76);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(140, 25);
            this.playerLabel.Text = "YOU";
            this.playerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // computerLabel
            //
            this.computerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.computerLabel.ForeColor = System.Drawing.Color.FromArgb(251, 146, 60);
            this.computerLabel.Location = new System.Drawing.Point(490, 76);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(140, 25);
            this.computerLabel.Text = "COMPUTER";
            this.computerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // statusLabel
            //
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.statusLabel.Location = new System.Drawing.Point(20, 474);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(560, 27);
            this.statusLabel.Text = "Click Start to play!";
            //
            // helpLabel
            //
            this.helpLabel.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.helpLabel.Location = new System.Drawing.Point(20, 510);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(420, 23);
            this.helpLabel.Text = "W  /  S     Move up and down";
            //
            // startButton
            //
            this.startButton.BackColor = System.Drawing.Color.FromArgb(34, 211, 238);
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.startButton.Location = new System.Drawing.Point(608, 480);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(172, 53);
            this.startButton.TabStop = false;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            //
            // gameTimer
            //
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.field);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.startButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.field.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel field;
        private System.Windows.Forms.Panel centerLine;
        private System.Windows.Forms.Panel player;
        private System.Windows.Forms.Panel computer;
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer gameTimer;
    }
}
