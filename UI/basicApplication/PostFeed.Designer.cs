namespace FacebookApplication.UI
{
    partial class PostFeed
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox postFeedTitle;
        private System.Windows.Forms.FlowLayoutPanel postList;
        private System.Windows.Forms.TextBox newPostLabel;

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
            this.postFeedTitle = new System.Windows.Forms.TextBox();
            this.postList = new System.Windows.Forms.FlowLayoutPanel();
            this.newPostLabel = new System.Windows.Forms.TextBox();
            this.loadMoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postFeedTitle
            // 
            this.postFeedTitle.BackColor = System.Drawing.SystemColors.Control;
            this.postFeedTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postFeedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postFeedTitle.Location = new System.Drawing.Point(22, 315);
            this.postFeedTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postFeedTitle.Name = "postFeedTitle";
            this.postFeedTitle.Size = new System.Drawing.Size(199, 32);
            this.postFeedTitle.TabIndex = 1;
            this.postFeedTitle.Text = "Recent Posts";
            // 
            // postList
            // 
            this.postList.AutoScroll = true;
            this.postList.AutoSize = true;
            this.postList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.postList.Location = new System.Drawing.Point(22, 358);
            this.postList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postList.Name = "postList";
            this.postList.Size = new System.Drawing.Size(622, 333);
            this.postList.TabIndex = 2;
            // 
            // newPostLabel
            // 
            this.newPostLabel.BackColor = System.Drawing.SystemColors.Control;
            this.newPostLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPostLabel.Location = new System.Drawing.Point(22, 16);
            this.newPostLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPostLabel.Name = "newPostLabel";
            this.newPostLabel.Size = new System.Drawing.Size(622, 32);
            this.newPostLabel.TabIndex = 4;
            this.newPostLabel.Text = "Publish a new post";
            // 
            // loadMoreButton
            // 
            this.loadMoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.loadMoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadMoreButton.ForeColor = System.Drawing.Color.White;
            this.loadMoreButton.Location = new System.Drawing.Point(420, 310);
            this.loadMoreButton.Name = "loadMoreButton";
            this.loadMoreButton.Size = new System.Drawing.Size(224, 44);
            this.loadMoreButton.TabIndex = 6;
            this.loadMoreButton.Text = "load more...";
            this.loadMoreButton.UseVisualStyleBackColor = false;
            this.loadMoreButton.Click += new System.EventHandler(this.loadMoreButton_Click);
            // 
            // PostFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.loadMoreButton);
            this.Controls.Add(this.newPostLabel);
            this.Controls.Add(this.postList);
            this.Controls.Add(this.postFeedTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(667, 0);
            this.MinimumSize = new System.Drawing.Size(667, 280);
            this.Name = "PostFeed";
            this.Size = new System.Drawing.Size(667, 693);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadMoreButton;
    }
}
