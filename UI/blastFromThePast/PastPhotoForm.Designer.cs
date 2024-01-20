namespace FacebookApplication.UI
{
    partial class PastPhotoForm
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
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.pageTitle = new System.Windows.Forms.Label();
            this.pictureDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userPictureBox
            // 
            this.userPictureBox.Location = new System.Drawing.Point(50, 140);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(726, 600);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // pageTitle
            // 
            this.pageTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pageTitle.ForeColor = System.Drawing.Color.White;
            this.pageTitle.Location = new System.Drawing.Point(53, 32);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(700, 35);
            this.pageTitle.TabIndex = 2;
            this.pageTitle.Text = "Remember this? This was back in:";
            this.pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureDate
            // 
            this.pictureDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.pictureDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pictureDate.Enabled = false;
            this.pictureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pictureDate.ForeColor = System.Drawing.Color.White;
            this.pictureDate.Location = new System.Drawing.Point(112, 83);
            this.pictureDate.Name = "pictureDate";
            this.pictureDate.ReadOnly = true;
            this.pictureDate.Size = new System.Drawing.Size(600, 28);
            this.pictureDate.TabIndex = 3;
            this.pictureDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PastPhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(828, 794);
            this.Controls.Add(this.pictureDate);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.userPictureBox);
            this.MaximizeBox = false;
            this.Name = "PastPhotoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blast from the past!";
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.TextBox pictureDate;
    }
}