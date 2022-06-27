using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NoteKeepingApp
{
    public partial class Home : Form
    {
        string noteTitle;
        string noteBody;
        bool update = false;
        int noteId;

        public Home()
        {
            InitializeComponent();
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            noteTitle = tbNoteTitle.Text;
            noteBody = rtbNoteBody.Text;

            if(update == true)
            {
                DBHelper.UpdateNoteInDb(noteId, noteTitle, noteBody);
                update = false;
            }
            else
            {
                DBHelper.InsertToDB(noteTitle, noteBody);
            }
            LoadNoteList();
            ClearForm();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            LoadNoteList();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Note selectedNote = (Note)lbAllNotes.SelectedItem;
            noteId = selectedNote.Id;
            tbNoteTitle.Text = selectedNote.Title;
            rtbNoteBody.Text = selectedNote.Body;
            update = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Note selectedNote = (Note)lbAllNotes.SelectedItem;
            noteId = selectedNote.Id;
            DBHelper.DeleteFromDb(noteId);
            LoadNoteList();
        }

        private void lbAllNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivateButtons();
            if (lbAllNotes.SelectedIndex != -1)
            {
                Note selectedNote = (Note)lbAllNotes.SelectedItem;
                SelectNote(selectedNote);
            }
            else
            {
                lblShowNoteTitle.Text = "";
                lblShowNoteBody.Text = "";
            }
        }

        private void LoadNoteList()
        {
            List<Note> notes = new List<Note>();
            lbAllNotes.DisplayMember = "Title";
            lbAllNotes.ValueMember = "Id";

            notes = DBHelper.SelectAllNotesFromDb();
            lbAllNotes.DataSource = notes;


            lbAllNotes.SelectedIndex = -1;
            ActivateButtons();
        }
        private void ClearForm()
        {
            tbNoteTitle.Text = "";
            rtbNoteBody.Text = "";
        }

        private void ActivateButtons()
        {
            if(lbAllNotes.SelectedIndex == -1)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void SelectNote(Note selectedNote)
        {
            noteId = selectedNote.Id;
            Note note = DBHelper.SelectFromDb(noteId);
            lblShowNoteTitle.Text = note.Title;
            lblShowNoteBody.Text = note.Body;
        }
    }
}
