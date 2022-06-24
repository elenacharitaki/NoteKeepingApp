namespace NoteKeepingApp
{
    partial class ShowNote
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
            this.lblShowTitle = new System.Windows.Forms.Label();
            this.lblShowBody = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShowTitle
            // 
            this.lblShowTitle.AutoSize = true;
            this.lblShowTitle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblShowTitle.Location = new System.Drawing.Point(200, 70);
            this.lblShowTitle.Name = "lblShowTitle";
            this.lblShowTitle.Size = new System.Drawing.Size(52, 28);
            this.lblShowTitle.TabIndex = 2;
            this.lblShowTitle.Text = "Title";
            this.lblShowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowBody
            // 
            this.lblShowBody.AutoSize = true;
            this.lblShowBody.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblShowBody.Location = new System.Drawing.Point(200, 150);
            this.lblShowBody.Name = "lblShowBody";
            this.lblShowBody.Size = new System.Drawing.Size(45, 21);
            this.lblShowBody.TabIndex = 3;
            this.lblShowBody.Text = "Body";
            this.lblShowBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lblShowBody);
            this.Controls.Add(this.lblShowTitle);
            this.Name = "ShowNote";
            this.Text = "Note";
            this.Load += new System.EventHandler(this.ShowNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblShowTitle;
        private System.Windows.Forms.Label lblShowBody;
    }
}