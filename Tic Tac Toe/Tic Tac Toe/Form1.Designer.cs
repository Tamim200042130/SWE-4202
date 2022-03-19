namespace Tic_Tac_Toe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.ComputerScore = new System.Windows.Forms.Label();
            this.AImoves = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(191, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1255, 7);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(999, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(7, 840);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Kristen ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(312, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 239);
            this.button1.TabIndex = 4;
            this.button1.Tag = "Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.playerClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Kristen ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(650, 75);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(345, 239);
            this.button2.TabIndex = 5;
            this.button2.Tag = "Play";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.playerClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Kristen ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(312, 327);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(323, 274);
            this.button4.TabIndex = 7;
            this.button4.Tag = "Play";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.playerClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Kristen ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(650, 327);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(345, 274);
            this.button5.TabIndex = 8;
            this.button5.Tag = "Play";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.playerClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Kristen ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1010, 75);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(323, 239);
            this.button3.TabIndex = 9;
            this.button3.Tag = "Play";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.playerClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Kristen ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1010, 327);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(323, 274);
            this.button6.TabIndex = 10;
            this.button6.Tag = "Play";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.playerClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Kristen ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(312, 614);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(323, 258);
            this.button7.TabIndex = 11;
            this.button7.Tag = "Play";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.playerClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Kristen ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(650, 614);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(345, 258);
            this.button8.TabIndex = 12;
            this.button8.Tag = "Play";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.playerClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Kristen ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(1010, 607);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(323, 265);
            this.button9.TabIndex = 13;
            this.button9.Tag = "Play";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.playerClick);
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.BackColor = System.Drawing.Color.Black;
            this.PlayerScore.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.ForeColor = System.Drawing.Color.White;
            this.PlayerScore.Image = ((System.Drawing.Image)(resources.GetObject("PlayerScore.Image")));
            this.PlayerScore.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PlayerScore.Location = new System.Drawing.Point(1298, 6);
            this.PlayerScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(206, 31);
            this.PlayerScore.TabIndex = 14;
            this.PlayerScore.Text = "Player Wins -  0";
            // 
            // ComputerScore
            // 
            this.ComputerScore.AutoSize = true;
            this.ComputerScore.BackColor = System.Drawing.Color.Black;
            this.ComputerScore.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerScore.ForeColor = System.Drawing.Color.White;
            this.ComputerScore.Image = ((System.Drawing.Image)(resources.GetObject("ComputerScore.Image")));
            this.ComputerScore.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ComputerScore.Location = new System.Drawing.Point(1534, 6);
            this.ComputerScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ComputerScore.Name = "ComputerScore";
            this.ComputerScore.Size = new System.Drawing.Size(251, 31);
            this.ComputerScore.TabIndex = 16;
            this.ComputerScore.Text = "Computer Wins -  0";
            // 
            // AImoves
            // 
            this.AImoves.Tick += new System.EventHandler(this.AImove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.rulesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1796, 37);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newGameToolStripMenuItem.BackgroundImage")));
            this.newGameToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newGameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newGameToolStripMenuItem.Image")));
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(157, 33);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.BackgroundImage")));
            this.infoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.infoToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(85, 33);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.restartToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartToolStripMenuItem.BackgroundImage")));
            this.restartToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.restartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restartToolStripMenuItem.Image")));
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(108, 33);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(191, 604);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1255, 7);
            this.label5.TabIndex = 19;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(639, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(7, 840);
            this.label4.TabIndex = 21;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rulesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rulesToolStripMenuItem.Image")));
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(92, 33);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1796, 920);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComputerScore);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Tag = "Play";
            this.Text = "Tic Tac Toe(Against AI)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label ComputerScore;
        private System.Windows.Forms.Timer AImoves;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
    }
}

