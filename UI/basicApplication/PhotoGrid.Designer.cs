namespace FacebookApplication.UI
{
    partial class PhotoGrid
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
            this.photoGridTable = new System.Windows.Forms.TableLayoutPanel();
            this.photoGridTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // photoGridTable
            // 
            this.photoGridTable.ColumnCount = 3;
            this.photoGridTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.photoGridTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.photoGridTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.photoGridTable.Location = new System.Drawing.Point(13, 90);
            this.photoGridTable.Name = "photoGridTable";
            this.photoGridTable.RowCount = 6;
            this.photoGridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.photoGridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.photoGridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.photoGridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.photoGridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.photoGridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.photoGridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.photoGridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.photoGridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.photoGridTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.photoGridTable.Size = new System.Drawing.Size(560, 1092);
            this.photoGridTable.TabIndex = 0;
            // 
            // photoGridTitle
            // 
            this.photoGridTitle.AutoSize = true;
            this.photoGridTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoGridTitle.Location = new System.Drawing.Point(16, 33);
            this.photoGridTitle.Name = "photoGridTitle";
            this.photoGridTitle.Size = new System.Drawing.Size(154, 29);
            this.photoGridTitle.TabIndex = 1;
            this.photoGridTitle.Text = "Your photos";
            // 
            // PhotoGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.photoGridTitle);
            this.Controls.Add(this.photoGridTable);
            this.MaximumSize = new System.Drawing.Size(585, 0);
            this.MinimumSize = new System.Drawing.Size(585, 0);
            this.Name = "PhotoGrid";
            this.Size = new System.Drawing.Size(585, 1200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel photoGridTable;
        private System.Windows.Forms.Label photoGridTitle;
    }
}
