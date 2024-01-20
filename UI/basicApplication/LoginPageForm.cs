using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;

namespace UI
{
    class LoginPageForm : Form
    {
        internal string AppId { get; set; }
        internal string[] AppPermissions { get; set; }
        internal LoginResult LoginDetails { get; set; }
        internal bool RememberUserCheckBox { get; set; }
        private Button loginButton;
        private CheckBox rememberUserCheckBox;
        private Button exitButton;

        internal LoginPageForm(string i_AppId, string[] i_AppPermissions)
        {
            AppId = i_AppId;
            AppPermissions = i_AppPermissions;
            InitializeComponent();
        }

        internal LoginResult DisplayLoginDialog()
        {
            this.ShowDialog();
            RememberUserCheckBox = rememberUserCheckBox.Checked;

            return LoginDetails;
        }

        private LoginResult login()
        {
            LoginResult loginResult = FacebookService.Login(AppId, AppPermissions);

            return loginResult;
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox logoPictureBox;
            System.Windows.Forms.TextBox appDescriptionBox;
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.rememberUserCheckBox = new System.Windows.Forms.CheckBox();
            logoPictureBox = new System.Windows.Forms.PictureBox();
            appDescriptionBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            logoPictureBox.ImageLocation = "https://i.ya-webdesign.com/images/facebook-white-logo-png-3.png";
            logoPictureBox.Location = new System.Drawing.Point(116, 199);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new System.Drawing.Size(558, 172);
            logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 2;
            logoPictureBox.TabStop = false;
            logoPictureBox.WaitOnLoad = true;
            // 
            // appDescriptionBox
            // 
            appDescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            appDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            appDescriptionBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appDescriptionBox.ForeColor = System.Drawing.Color.White;
            appDescriptionBox.Location = new System.Drawing.Point(116, 349);
            appDescriptionBox.Name = "appDescriptionBox";
            appDescriptionBox.Size = new System.Drawing.Size(558, 31);
            appDescriptionBox.TabIndex = 3;
            appDescriptionBox.Text = "DESKTOP APPLICATION";
            appDescriptionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(116, 524);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(271, 53);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // ExitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Gray;
            this.exitButton.Location = new System.Drawing.Point(403, 524);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(271, 53);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rememberUserCheckBox
            // 
            this.rememberUserCheckBox.AutoSize = true;
            this.rememberUserCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberUserCheckBox.ForeColor = System.Drawing.Color.White;
            this.rememberUserCheckBox.Location = new System.Drawing.Point(306, 597);
            this.rememberUserCheckBox.Name = "rememberUserCheckBox";
            this.rememberUserCheckBox.Size = new System.Drawing.Size(218, 29);
            this.rememberUserCheckBox.TabIndex = 4;
            this.rememberUserCheckBox.Text = "Keep me logged in";
            this.rememberUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginPageForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.rememberUserCheckBox);
            this.Controls.Add(appDescriptionBox);
            this.Controls.Add(logoPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Desktop Application";
            ((System.ComponentModel.ISupportInitialize)(logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            LoginDetails = null;
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginDetails = this.login();
            this.Close();
        }
    }
}
