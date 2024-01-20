namespace FacebookApplication.HW2_additions
{
    partial class FriendsSidebar
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.friendsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.birthdaysTitle = new System.Windows.Forms.Label();
            this.birthdaysLayout = new System.Windows.Forms.TableLayoutPanel();
            this.birthdayPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(25, 429);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(164, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Your Friends";
            // 
            // friendsLayoutPanel
            // 
            this.friendsLayoutPanel.AutoSize = true;
            this.friendsLayoutPanel.ColumnCount = 2;
            this.friendsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.50641F));
            this.friendsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.49359F));
            this.friendsLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsLayoutPanel.Location = new System.Drawing.Point(30, 484);
            this.friendsLayoutPanel.Name = "friendsLayoutPanel";
            this.friendsLayoutPanel.RowCount = 1;
            this.friendsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.friendsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.friendsLayoutPanel.Size = new System.Drawing.Size(493, 102);
            this.friendsLayoutPanel.TabIndex = 1;
            // 
            // birthdaysTitle
            // 
            this.birthdaysTitle.AutoSize = true;
            this.birthdaysTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdaysTitle.Location = new System.Drawing.Point(25, 244);
            this.birthdaysTitle.Name = "birthdaysTitle";
            this.birthdaysTitle.Size = new System.Drawing.Size(246, 29);
            this.birthdaysTitle.TabIndex = 2;
            this.birthdaysTitle.Text = "Upcoming Birthdays";
            // 
            // birthdaysLayout
            // 
            this.birthdaysLayout.AutoSize = true;
            this.birthdaysLayout.ColumnCount = 2;
            this.birthdaysLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.50641F));
            this.birthdaysLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.49359F));
            this.birthdaysLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdaysLayout.Location = new System.Drawing.Point(30, 297);
            this.birthdaysLayout.Name = "birthdaysLayout";
            this.birthdaysLayout.RowCount = 1;
            this.birthdaysLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.birthdaysLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.birthdaysLayout.Size = new System.Drawing.Size(493, 102);
            this.birthdaysLayout.TabIndex = 3;
            // 
            // birthdayPicBox
            // 
            this.birthdayPicBox.ImageLocation = "https://techcrunch.com/wp-content/uploads/2017/08/facebook-birthdays.png";
            this.birthdayPicBox.Location = new System.Drawing.Point(0, 0);
            this.birthdayPicBox.Name = "birthdayPicBox";
            this.birthdayPicBox.Size = new System.Drawing.Size(547, 222);
            this.birthdayPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birthdayPicBox.TabIndex = 5;
            this.birthdayPicBox.TabStop = false;
            // 
            // FriendsSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.birthdayPicBox);
            this.Controls.Add(this.birthdaysLayout);
            this.Controls.Add(this.birthdaysTitle);
            this.Controls.Add(this.friendsLayoutPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FriendsSidebar";
            this.Size = new System.Drawing.Size(549, 1049);
            ((System.ComponentModel.ISupportInitialize)(this.birthdayPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel friendsLayoutPanel;
        private System.Windows.Forms.Label birthdaysTitle;
        private System.Windows.Forms.TableLayoutPanel birthdaysLayout;
        private System.Windows.Forms.PictureBox birthdayPicBox;
    }
}
