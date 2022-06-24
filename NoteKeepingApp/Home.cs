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

        private void btnShow_Click(object sender, EventArgs e)
        {
            Note selectedNote = (Note)lbAllNotes.SelectedItem;
            noteId = selectedNote.Id;
            ShowNote noteForm = new ShowNote(noteId);
            noteForm.Show();
            noteForm.Activate();
        }

        private void lbAllNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivateButtons();
        }

        private void LoadNoteList()
        {
            List<Note> notes = new List<Note>();
            lbAllNotes.DisplayMember = "Title";
            lbAllNotes.ValueMember = "Id";

            notes = DBHelper.SelectAllNotesFromDb();
            lbAllNotes.DataSource = notes;


            lbAllNotes.SelectedItem = null;
            ActivateButtons();
        }
        private void ClearForm()
        {
            tbNoteTitle.Text = "";
            rtbNoteBody.Text = "";
        }

        private void ActivateButtons()
        {
            if(lbAllNotes.SelectedItem == null)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnShow.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnShow.Enabled = true;
            }
        }
    }
}
