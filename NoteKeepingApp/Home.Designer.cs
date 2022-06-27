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
            this.notesDbDataSet1 = new NoteKeepingApp.NotesDbDataSet();
            this.lblNewNote = new System.Windows.Forms.Label();
            this.lblShowNoteTitle = new System.Windows.Forms.Label();
            this.lblShowNoteBody = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notesDbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAllNotes
            // 
            this.lbAllNotes.FormattingEnabled = true;
            this.lbAllNotes.ItemHeight = 16;
            this.lbAllNotes.Location = new System.Drawing.Point(454, 61);
            this.lbAllNotes.Name = "lbAllNotes";
            this.lbAllNotes.Size = new System.Drawing.Size(323, 228);
            this.lbAllNotes.TabIndex = 0;
            this.lbAllNotes.SelectedIndexChanged += new System.EventHandler(this.lbAllNotes_SelectedIndexChanged);
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Location = new System.Drawing.Point(179, 307);
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
            this.lblNoteTitle.Location = new System.Drawing.Point(86, 83);
            this.lblNoteTitle.Name = "lblNoteTitle";
            this.lblNoteTitle.Size = new System.Drawing.Size(33, 16);
            this.lblNoteTitle.TabIndex = 2;
            this.lblNoteTitle.Text = "Title";
            // 
            // tbNoteTitle
            // 
            this.tbNoteTitle.Location = new System.Drawing.Point(89, 102);
            this.tbNoteTitle.Name = "tbNoteTitle";
            this.tbNoteTitle.Size = new System.Drawing.Size(313, 22);
            this.tbNoteTitle.TabIndex = 3;
            // 
            // lblNoteBody
            // 
            this.lblNoteBody.AutoSize = true;
            this.lblNoteBody.Location = new System.Drawing.Point(86, 150);
            this.lblNoteBody.Name = "lblNoteBody";
            this.lblNoteBody.Size = new System.Drawing.Size(39, 16);
            this.lblNoteBody.TabIndex = 4;
            this.lblNoteBody.Text = "Body";
            // 
            // rtbNoteBody
            // 
            this.rtbNoteBody.Location = new System.Drawing.Point(89, 169);
            this.rtbNoteBody.Name = "rtbNoteBody";
            this.rtbNoteBody.Size = new System.Drawing.Size(313, 96);
            this.rtbNoteBody.TabIndex = 5;
            this.rtbNoteBody.Text = "";
            // 
            // lblAllNotes
            // 
            this.lblAllNotes.AutoSize = true;
            this.lblAllNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAllNotes.Location = new System.Drawing.Point(450, 38);
            this.lblAllNotes.Name = "lblAllNotes";
            this.lblAllNotes.Size = new System.Drawing.Size(74, 20);
            this.lblAllNotes.TabIndex = 6;
            this.lblAllNotes.Text = "All notes";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(454, 308);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 25);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(641, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 25);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // notesDbDataSet1
            // 
            this.notesDbDataSet1.DataSetName = "NotesDbDataSet";
            this.notesDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNewNote
            // 
            this.lblNewNote.AutoSize = true;
            this.lblNewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblNewNote.Location = new System.Drawing.Point(85, 38);
            this.lblNewNote.Name = "lblNewNote";
            this.lblNewNote.Size = new System.Drawing.Size(79, 20);
            this.lblNewNote.TabIndex = 10;
            this.lblNewNote.Text = "New note";
            // 
            // lblShowNoteTitle
            // 
            this.lblShowNoteTitle.AutoSize = true;
            this.lblShowNoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblShowNoteTitle.Location = new System.Drawing.Point(90, 391);
            this.lblShowNoteTitle.MaximumSize = new System.Drawing.Size(720, 0);
            this.lblShowNoteTitle.Name = "lblShowNoteTitle";
            this.lblShowNoteTitle.Size = new System.Drawing.Size(0, 29);
            this.lblShowNoteTitle.TabIndex = 11;
            // 
            // lblShowNoteBody
            // 
            this.lblShowNoteBody.AutoSize = true;
            this.lblShowNoteBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblShowNoteBody.Location = new System.Drawing.Point(90, 458);
            this.lblShowNoteBody.MaximumSize = new System.Drawing.Size(720, 0);
            this.lblShowNoteBody.Name = "lblShowNoteBody";
            this.lblShowNoteBody.Size = new System.Drawing.Size(0, 22);
            this.lblShowNoteBody.TabIndex = 12;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.lblShowNoteBody);
            this.Controls.Add(this.lblShowNoteTitle);
            this.Controls.Add(this.lblNewNote);
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
            ((System.ComponentModel.ISupportInitialize)(this.notesDbDataSet1)).EndInit();
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
        private NotesDbDataSet notesDbDataSet1;
        private System.Windows.Forms.Label lblNewNote;
        private System.Windows.Forms.Label lblShowNoteTitle;
        private System.Windows.Forms.Label lblShowNoteBody;
    }
}

