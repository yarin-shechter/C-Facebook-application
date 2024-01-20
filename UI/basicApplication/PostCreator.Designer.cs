namespace FacebookApplication.UI
{
    partial class PostCreator
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
            this.postContent = new System.Windows.Forms.TextBox();
            this.publishButton = new System.Windows.Forms.Button();
            this.postAuthorPicBox = new System.Windows.Forms.PictureBox();
            this.publishAsTextBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // postContent
            // 
            this.postContent.BackColor = System.Drawing.Color.White;
            this.postContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postContent.Location = new System.Drawing.Point(125, 27);
            this.postContent.Multiline = true;
            this.postContent.Name = "postContent";
            this.postContent.Size = new System.Drawing.Size(546, 166);
            this.postContent.TabIndex = 0;
            // 
            // publishButton
            // 
            this.publishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.publishButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.publishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishButton.ForeColor = System.Drawing.Color.White;
            this.publishButton.Location = new System.Drawing.Point(311, 209);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(362, 67);
            this.publishButton.TabIndex = 3;
            this.publishButton.Text = "Publish";
            this.publishButton.UseVisualStyleBackColor = false;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // postAuthorPicBox
            // 
            this.postAuthorPicBox.Location = new System.Drawing.Point(15, 28);
            this.postAuthorPicBox.Name = "postAuthorPicBox";
            this.postAuthorPicBox.Size = new System.Drawing.Size(94, 92);
            this.postAuthorPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.postAuthorPicBox.TabIndex = 5;
            this.postAuthorPicBox.TabStop = false;
            // 
            // publishAsTextBox
            // 
            this.publishAsTextBox.AutoSize = true;
            this.publishAsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishAsTextBox.ForeColor = System.Drawing.Color.Gray;
            this.publishAsTextBox.Location = new System.Drawing.Point(20, 251);
            this.publishAsTextBox.Name = "publishAsTextBox";
            this.publishAsTextBox.Size = new System.Drawing.Size(0, 25);
            this.publishAsTextBox.TabIndex = 6;
            // 
            // PostCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.publishAsTextBox);
            this.Controls.Add(this.postAuthorPicBox);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.postContent);
            this.MaximumSize = new System.Drawing.Size(700, 300);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "PostCreator";
            this.Size = new System.Drawing.Size(700, 300);
            ((System.ComponentModel.ISupportInitialize)(this.postAuthorPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox postContent;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.PictureBox postAuthorPicBox;
        private System.Windows.Forms.Label publishAsTextBox;
    }
}
