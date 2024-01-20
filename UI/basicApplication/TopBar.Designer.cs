namespace FacebookApplication.UI
{
    partial class TopBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.facebookLogoPicture = new System.Windows.Forms.PictureBox();
            this.profilePicBox = new System.Windows.Forms.PictureBox();
            this.separator1 = new System.Windows.Forms.Label();
            this.separator2 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.separator3 = new System.Windows.Forms.Label();
            this.blastFromThePastButton = new System.Windows.Forms.Button();
            this.friendsTriviaButton = new System.Windows.Forms.Button();
            this.separator4 = new System.Windows.Forms.Label();
            this.separator5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // facebookLogoPicture
            // 
            this.facebookLogoPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebookLogoPicture.ImageLocation = "https://f-scope.net/images/facebook-logo-png-white-10.png";
            this.facebookLogoPicture.Location = new System.Drawing.Point(2, 6);
            this.facebookLogoPicture.Name = "facebookLogoPicture";
            this.facebookLogoPicture.Size = new System.Drawing.Size(74, 37);
            this.facebookLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.facebookLogoPicture.TabIndex = 0;
            this.facebookLogoPicture.TabStop = false;
            this.facebookLogoPicture.Click += new System.EventHandler(this.facebookLogoPicture_Click);
            // 
            // profilePicBox
            // 
            this.profilePicBox.Location = new System.Drawing.Point(965, 0);
            this.profilePicBox.Name = "profilePicBox";
            this.profilePicBox.Size = new System.Drawing.Size(73, 49);
            this.profilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicBox.TabIndex = 1;
            this.profilePicBox.TabStop = false;
            // 
            // separator1
            // 
            this.separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(174)))), ((int)(((byte)(216)))));
            this.separator1.Enabled = false;
            this.separator1.Location = new System.Drawing.Point(1501, 13);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(1, 22);
            this.separator1.TabIndex = 5;
            // 
            // separator2
            // 
            this.separator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(174)))), ((int)(((byte)(216)))));
            this.separator2.Enabled = false;
            this.separator2.Location = new System.Drawing.Point(1599, 13);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(1, 22);
            this.separator2.TabIndex = 8;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(1512, 8);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(81, 32);
            this.homeButton.TabIndex = 10;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(1606, 8);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(81, 32);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.Transparent;
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.profileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.Location = new System.Drawing.Point(1030, 10);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(81, 32);
            this.profileButton.TabIndex = 12;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // separator3
            // 
            this.separator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(174)))), ((int)(((byte)(216)))));
            this.separator3.Enabled = false;
            this.separator3.Location = new System.Drawing.Point(1302, 13);
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(1, 22);
            this.separator3.TabIndex = 13;
            // 
            // blastFromThePastButton
            // 
            this.blastFromThePastButton.AutoSize = true;
            this.blastFromThePastButton.BackColor = System.Drawing.Color.Transparent;
            this.blastFromThePastButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blastFromThePastButton.FlatAppearance.BorderSize = 0;
            this.blastFromThePastButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.blastFromThePastButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.blastFromThePastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blastFromThePastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.blastFromThePastButton.ForeColor = System.Drawing.Color.White;
            this.blastFromThePastButton.Location = new System.Drawing.Point(1316, 8);
            this.blastFromThePastButton.Name = "blastFromThePastButton";
            this.blastFromThePastButton.Size = new System.Drawing.Size(187, 32);
            this.blastFromThePastButton.TabIndex = 14;
            this.blastFromThePastButton.Text = "Blast From The Past!";
            this.blastFromThePastButton.UseVisualStyleBackColor = false;
            this.blastFromThePastButton.Click += new System.EventHandler(this.blastFromThePastButton_Click);
            // 
            // friendsTriviaButton
            // 
            this.friendsTriviaButton.BackColor = System.Drawing.Color.Transparent;
            this.friendsTriviaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.friendsTriviaButton.FlatAppearance.BorderSize = 0;
            this.friendsTriviaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.friendsTriviaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.friendsTriviaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendsTriviaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsTriviaButton.ForeColor = System.Drawing.Color.White;
            this.friendsTriviaButton.Location = new System.Drawing.Point(1131, 8);
            this.friendsTriviaButton.Name = "friendsTriviaButton";
            this.friendsTriviaButton.Size = new System.Drawing.Size(162, 32);
            this.friendsTriviaButton.TabIndex = 13;
            this.friendsTriviaButton.Text = "My Friends Trivia!";
            this.friendsTriviaButton.UseVisualStyleBackColor = false;
            this.friendsTriviaButton.Click += new System.EventHandler(this.friendsTriviaButton_Click);
            // 
            // separator4
            // 
            this.separator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(174)))), ((int)(((byte)(216)))));
            this.separator4.Enabled = false;
            this.separator4.Location = new System.Drawing.Point(1125, 13);
            this.separator4.Name = "separator4";
            this.separator4.Size = new System.Drawing.Size(1, 22);
            this.separator4.TabIndex = 15;
            // 
            // separator5
            // 
            this.separator5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(174)))), ((int)(((byte)(216)))));
            this.separator5.Enabled = false;
            this.separator5.Location = new System.Drawing.Point(1512, 13);
            this.separator5.Name = "separator5";
            this.separator5.Size = new System.Drawing.Size(1, 22);
            this.separator5.TabIndex = 16;
            // 
            // TopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.separator5);
            this.Controls.Add(this.separator4);
            this.Controls.Add(this.blastFromThePastButton);
            this.Controls.Add(this.separator3);
            this.Controls.Add(this.friendsTriviaButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.separator2);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.profilePicBox);
            this.Controls.Add(this.facebookLogoPicture);
            this.Name = "TopBar";
            this.Size = new System.Drawing.Size(1707, 48);
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox facebookLogoPicture;
        private System.Windows.Forms.PictureBox profilePicBox;
        private System.Windows.Forms.Label separator1;
        private System.Windows.Forms.Label separator2;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Label separator3;
        private System.Windows.Forms.Button blastFromThePastButton;
        private System.Windows.Forms.Button friendsTriviaButton;
        private System.Windows.Forms.Label separator4;
        private System.Windows.Forms.Label separator5;
    }
}
