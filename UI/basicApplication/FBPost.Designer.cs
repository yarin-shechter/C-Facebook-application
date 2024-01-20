namespace FacebookApplication.UI
{
    partial class FBPost
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
            this.authorPicBox = new System.Windows.Forms.PictureBox();
            this.postMetadataTextBox = new System.Windows.Forms.TextBox();
            this.authorNameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.likedByTextBox = new System.Windows.Forms.TextBox();
            this.attachedPicBox = new System.Windows.Forms.PictureBox();
            this.postDivider = new System.Windows.Forms.TextBox();
            this.likeButton = new System.Windows.Forms.Button();
            this.commentButton = new System.Windows.Forms.Button();
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.authorPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachedPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // authorPicBox
            // 
            this.authorPicBox.Location = new System.Drawing.Point(31, 17);
            this.authorPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authorPicBox.Name = "authorPicBox";
            this.authorPicBox.Size = new System.Drawing.Size(98, 83);
            this.authorPicBox.TabIndex = 0;
            this.authorPicBox.TabStop = false;
            // 
            // postMetadataTextBox
            // 
            this.postMetadataTextBox.BackColor = System.Drawing.Color.White;
            this.postMetadataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postMetadataTextBox.ForeColor = System.Drawing.Color.Gray;
            this.postMetadataTextBox.Location = new System.Drawing.Point(148, 56);
            this.postMetadataTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postMetadataTextBox.Name = "postMetadataTextBox";
            this.postMetadataTextBox.ReadOnly = true;
            this.postMetadataTextBox.Size = new System.Drawing.Size(442, 15);
            this.postMetadataTextBox.TabIndex = 1;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.BackColor = System.Drawing.Color.White;
            this.authorNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.authorNameTextBox.Location = new System.Drawing.Point(148, 24);
            this.authorNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.ReadOnly = true;
            this.authorNameTextBox.Size = new System.Drawing.Size(442, 19);
            this.authorNameTextBox.TabIndex = 2;
            // 
            // likedByTextBox
            // 
            this.likedByTextBox.BackColor = System.Drawing.Color.White;
            this.likedByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.likedByTextBox.Location = new System.Drawing.Point(30, 493);
            this.likedByTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.likedByTextBox.Name = "likedByTextBox";
            this.likedByTextBox.ReadOnly = true;
            this.likedByTextBox.Size = new System.Drawing.Size(560, 15);
            this.likedByTextBox.TabIndex = 4;
            // 
            // attachedPicBox
            // 
            this.attachedPicBox.BackColor = System.Drawing.Color.Transparent;
            this.attachedPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.attachedPicBox.ImageLocation = "";
            this.attachedPicBox.Location = new System.Drawing.Point(30, 238);
            this.attachedPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attachedPicBox.MaximumSize = new System.Drawing.Size(560, 320);
            this.attachedPicBox.Name = "attachedPicBox";
            this.attachedPicBox.Size = new System.Drawing.Size(560, 242);
            this.attachedPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.attachedPicBox.TabIndex = 5;
            this.attachedPicBox.TabStop = false;
            this.attachedPicBox.WaitOnLoad = true;
            // 
            // postDivider
            // 
            this.postDivider.BackColor = System.Drawing.SystemColors.Control;
            this.postDivider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postDivider.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postDivider.Location = new System.Drawing.Point(1, 588);
            this.postDivider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postDivider.Name = "postDivider";
            this.postDivider.Size = new System.Drawing.Size(619, 12);
            this.postDivider.TabIndex = 6;
            // 
            // likeButton
            // 
            this.likeButton.BackColor = System.Drawing.Color.Transparent;
            this.likeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.likeButton.Location = new System.Drawing.Point(30, 523);
            this.likeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(276, 49);
            this.likeButton.TabIndex = 7;
            this.likeButton.Text = "Like";
            this.likeButton.UseVisualStyleBackColor = false;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // commentButton
            // 
            this.commentButton.BackColor = System.Drawing.Color.Transparent;
            this.commentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.commentButton.Location = new System.Drawing.Point(324, 523);
            this.commentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(266, 49);
            this.commentButton.TabIndex = 8;
            this.commentButton.Text = "Add a comment";
            this.commentButton.UseVisualStyleBackColor = false;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // contentTextBox
            // 
            this.contentTextBox.BackColor = System.Drawing.Color.White;
            this.contentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contentTextBox.Location = new System.Drawing.Point(31, 115);
            this.contentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ReadOnly = true;
            this.contentTextBox.Size = new System.Drawing.Size(559, 110);
            this.contentTextBox.TabIndex = 9;
            this.contentTextBox.Text = "";
            // 
            // FBPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.postDivider);
            this.Controls.Add(this.attachedPicBox);
            this.Controls.Add(this.likedByTextBox);
            this.Controls.Add(this.authorNameTextBox);
            this.Controls.Add(this.postMetadataTextBox);
            this.Controls.Add(this.authorPicBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(622, 1200);
            this.MinimumSize = new System.Drawing.Size(622, 0);
            this.Name = "FBPost";
            this.Size = new System.Drawing.Size(622, 602);
            ((System.ComponentModel.ISupportInitialize)(this.authorPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachedPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox authorPicBox;
        private System.Windows.Forms.TextBox postMetadataTextBox;
        private System.Windows.Forms.MaskedTextBox authorNameTextBox;
        private System.Windows.Forms.TextBox likedByTextBox;
        private System.Windows.Forms.PictureBox attachedPicBox;
        private System.Windows.Forms.TextBox postDivider;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.RichTextBox contentTextBox;
    }
}
