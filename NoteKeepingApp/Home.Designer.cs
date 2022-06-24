namespace NoteKeepingApp
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
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
            this.lbAllNotes.SelectedIndexChanged += new System.EventHandler(this.lbAllNotes_SelectedIndexChanged);
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Location = new System.Drawing.Point(169, 297);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(130, 25);
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(444, 339);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 25);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(666, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(555, 339);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 25);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblAllNotes);
            this.Controls.Add(this.rtbNoteBody);
            this.Controls.Add(this.lblNoteBody);
            this.Controls.Add(this.tbNoteTitle);
            this.Controls.Add(this.lblNoteTitle);
            this.Controls.Add(this.btnSaveNote);
            this.Controls.Add(this.lbAllNotes);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
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
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
    }
}

