namespace FacebookApplication.UI
{
    partial class ProfileHeader
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label aboutLabel;
            System.Windows.Forms.Label currentWorkplaceLabel;
            System.Windows.Forms.Label hobbiesLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label genderLabel;
            this.coverPicBox = new System.Windows.Forms.PictureBox();
            this.profilePicBox = new System.Windows.Forms.PictureBox();
            this.userFullName = new System.Windows.Forms.Label();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.currentWorkplaceTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.hobbiesTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.userDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            aboutLabel = new System.Windows.Forms.Label();
            currentWorkplaceLabel = new System.Windows.Forms.Label();
            hobbiesLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coverPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).BeginInit();
            this.descriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDescriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aboutLabel.Location = new System.Drawing.Point(27, 127);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new System.Drawing.Size(87, 29);
            aboutLabel.TabIndex = 4;
            aboutLabel.Text = "About:";
            // 
            // currentWorkplaceLabel
            // 
            currentWorkplaceLabel.AutoSize = true;
            currentWorkplaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentWorkplaceLabel.Location = new System.Drawing.Point(25, 258);
            currentWorkplaceLabel.Name = "currentWorkplaceLabel";
            currentWorkplaceLabel.Size = new System.Drawing.Size(237, 29);
            currentWorkplaceLabel.TabIndex = 8;
            currentWorkplaceLabel.Text = "Current Workplace:";
            // 
            // hobbiesLabel
            // 
            hobbiesLabel.AutoSize = true;
            hobbiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hobbiesLabel.Location = new System.Drawing.Point(26, 391);
            hobbiesLabel.Name = "hobbiesLabel";
            hobbiesLabel.Size = new System.Drawing.Size(118, 29);
            hobbiesLabel.TabIndex = 9;
            hobbiesLabel.Text = "Hobbies:";
            // 
            // coverPicBox
            // 
            this.coverPicBox.Location = new System.Drawing.Point(0, 0);
            this.coverPicBox.Name = "coverPicBox";
            this.coverPicBox.Size = new System.Drawing.Size(687, 300);
            this.coverPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPicBox.TabIndex = 0;
            this.coverPicBox.TabStop = false;
            // 
            // profilePicBox
            // 
            this.profilePicBox.Location = new System.Drawing.Point(30, 238);
            this.profilePicBox.Name = "profilePicBox";
            this.profilePicBox.Size = new System.Drawing.Size(252, 244);
            this.profilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicBox.TabIndex = 1;
            this.profilePicBox.TabStop = false;
            // 
            // userFullName
            // 
            this.userFullName.AutoSize = true;
            this.userFullName.BackColor = System.Drawing.Color.Transparent;
            this.userFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userFullName.ForeColor = System.Drawing.Color.Black;
            this.userFullName.Location = new System.Drawing.Point(291, 312);
            this.userFullName.Name = "userFullName";
            this.userFullName.Size = new System.Drawing.Size(0, 55);
            this.userFullName.TabIndex = 2;
            this.userFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDescriptionBindingSource, "About", true));
            this.aboutTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTextBox.Location = new System.Drawing.Point(27, 168);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.Size = new System.Drawing.Size(635, 78);
            this.aboutTextBox.TabIndex = 8;
            // 
            // currentWorkplaceTextBox
            // 
            this.currentWorkplaceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentWorkplaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDescriptionBindingSource, "CurrentWorkplace", true));
            this.currentWorkplaceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWorkplaceTextBox.Location = new System.Drawing.Point(29, 300);
            this.currentWorkplaceTextBox.Multiline = true;
            this.currentWorkplaceTextBox.Name = "currentWorkplaceTextBox";
            this.currentWorkplaceTextBox.ReadOnly = true;
            this.currentWorkplaceTextBox.Size = new System.Drawing.Size(637, 78);
            this.currentWorkplaceTextBox.TabIndex = 9;
            // 
            // editButton
            // 
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(581, 316);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(90, 26);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionPanel.Controls.Add(genderLabel);
            this.descriptionPanel.Controls.Add(this.genderTextBox);
            this.descriptionPanel.Controls.Add(currentWorkplaceLabel);
            this.descriptionPanel.Controls.Add(aboutLabel);
            this.descriptionPanel.Controls.Add(hobbiesLabel);
            this.descriptionPanel.Controls.Add(this.hobbiesTextBox);
            this.descriptionPanel.Controls.Add(this.aboutTextBox);
            this.descriptionPanel.Controls.Add(this.currentWorkplaceTextBox);
            this.descriptionPanel.Location = new System.Drawing.Point(3, 412);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(686, 619);
            this.descriptionPanel.TabIndex = 1;
            // 
            // hobbiesTextBox
            // 
            this.hobbiesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hobbiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDescriptionBindingSource, "Hobbies", true));
            this.hobbiesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hobbiesTextBox.Location = new System.Drawing.Point(31, 434);
            this.hobbiesTextBox.Multiline = true;
            this.hobbiesTextBox.Name = "hobbiesTextBox";
            this.hobbiesTextBox.ReadOnly = true;
            this.hobbiesTextBox.Size = new System.Drawing.Size(635, 78);
            this.hobbiesTextBox.TabIndex = 10;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.Location = new System.Drawing.Point(288, 369);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(115, 29);
            birthdayLabel.TabIndex = 10;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDescriptionBindingSource, "Birthday", true));
            this.birthdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayTextBox.Location = new System.Drawing.Point(405, 367);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.ReadOnly = true;
            this.birthdayTextBox.Size = new System.Drawing.Size(262, 28);
            this.birthdayTextBox.TabIndex = 11;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(293, 33);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(107, 29);
            genderLabel.TabIndex = 11;
            genderLabel.Text = "Gender:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDescriptionBindingSource, "Gender", true));
            this.genderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTextBox.Location = new System.Drawing.Point(408, 32);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(262, 28);
            this.genderTextBox.TabIndex = 12;
            // 
            // userDescriptionBindingSource
            // 
            this.userDescriptionBindingSource.DataSource = typeof(FacebookApplication.HW2_additions.UserDescription);
            // 
            // ProfileHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.userFullName);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.profilePicBox);
            this.Controls.Add(this.coverPicBox);
            this.Controls.Add(this.descriptionPanel);
            this.Name = "ProfileHeader";
            this.Size = new System.Drawing.Size(689, 1049);
            ((System.ComponentModel.ISupportInitialize)(this.coverPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).EndInit();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDescriptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverPicBox;
        private System.Windows.Forms.PictureBox profilePicBox;
        private System.Windows.Forms.Label userFullName;
        private System.Windows.Forms.BindingSource userDescriptionBindingSource;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.TextBox currentWorkplaceTextBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.TextBox hobbiesTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox birthdayTextBox;
    }
}
