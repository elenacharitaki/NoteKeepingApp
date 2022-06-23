﻿namespace NoteKeepingApp
{
    partial class Home
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
            this.lbAllNotes = new System.Windows.Forms.ListBox();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.lblNoteTitle = new System.Windows.Forms.Label();
            this.tbNoteTitle = new System.Windows.Forms.TextBox();
            this.lblNoteBody = new System.Windows.Forms.Label();
            this.rtbNoteBody = new System.Windows.Forms.RichTextBox();
            this.lblAllNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAllNotes
            // 
            this.lbAllNotes.FormattingEnabled = true;
            this.lbAllNotes.ItemHeight = 16;
            this.lbAllNotes.Location = new System.Drawing.Point(444, 92);
            this.lbAllNotes.Name = "lbAllNotes";
            this.lbAllNotes.Size = new System.Drawing.Size(323, 228);
            this.lbAllNotes.TabIndex = 0;
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Location = new System.Drawing.Point(169, 297);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(129, 23);
            this.btnSaveNote.TabIndex = 1;
            this.btnSaveNote.Text = "Save note";
            this.btnSaveNote.UseVisualStyleBackColor = true;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // lblNoteTitle
            // 
            this.lblNoteTitle.AutoSize = true;
            this.lblNoteTitle.Location = new System.Drawing.Point(76, 73);
            this.lblNoteTitle.Name = "lblNoteTitle";
            this.lblNoteTitle.Size = new System.Drawing.Size(33, 16);
            this.lblNoteTitle.TabIndex = 2;
            this.lblNoteTitle.Text = "Title";
            // 
            // tbNoteTitle
            // 
            this.tbNoteTitle.Location = new System.Drawing.Point(79, 92);
            this.tbNoteTitle.Name = "tbNoteTitle";
            this.tbNoteTitle.Size = new System.Drawing.Size(313, 22);
            this.tbNoteTitle.TabIndex = 3;
            // 
            // lblNoteBody
            // 
            this.lblNoteBody.AutoSize = true;
            this.lblNoteBody.Location = new System.Drawing.Point(76, 140);
            this.lblNoteBody.Name = "lblNoteBody";
            this.lblNoteBody.Size = new System.Drawing.Size(39, 16);
            this.lblNoteBody.TabIndex = 4;
            this.lblNoteBody.Text = "Body";
            // 
            // rtbNoteBody
            // 
            this.rtbNoteBody.Location = new System.Drawing.Point(79, 159);
            this.rtbNoteBody.Name = "rtbNoteBody";
            this.rtbNoteBody.Size = new System.Drawing.Size(313, 96);
            this.rtbNoteBody.TabIndex = 5;
            this.rtbNoteBody.Text = "";
            // 
            // lblAllNotes
            // 
            this.lblAllNotes.AutoSize = true;
            this.lblAllNotes.Location = new System.Drawing.Point(441, 73);
            this.lblAllNotes.Name = "lblAllNotes";
            this.lblAllNotes.Size = new System.Drawing.Size(58, 16);
            this.lblAllNotes.TabIndex = 6;
            this.lblAllNotes.Text = "All notes";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAllNotes);
            this.Controls.Add(this.rtbNoteBody);
            this.Controls.Add(this.lblNoteBody);
            this.Controls.Add(this.tbNoteTitle);
            this.Controls.Add(this.lblNoteTitle);
            this.Controls.Add(this.btnSaveNote);
            this.Controls.Add(this.lbAllNotes);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAllNotes;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.Label lblNoteTitle;
        private System.Windows.Forms.TextBox tbNoteTitle;
        private System.Windows.Forms.Label lblNoteBody;
        private System.Windows.Forms.RichTextBox rtbNoteBody;
        private System.Windows.Forms.Label lblAllNotes;
    }
}
