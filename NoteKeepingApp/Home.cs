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

        private void Home_Load(object sender, EventArgs e)
        {
            LoadNoteList();
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            noteTitle = tbNoteTitle.Text;
            noteBody = rtbNoteBody.Text;

            if(update == true)
            {
                DBHelper.UpdateNote(noteId, noteTitle, noteBody);
                update = false;
            }
            else
            {
                DBHelper.InsertNote(noteTitle, noteBody);
            }
            LoadNoteList();
            ClearForm();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //fill the form with note's data to update
            Note selectedNote = (Note)lbAllNotes.SelectedItem;
            noteId = selectedNote.Id;
            tbNoteTitle.Text = selectedNote.Title;
            rtbNoteBody.Text = selectedNote.Body;
            update = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete note from db, clear form and reload the list
            update = false; 
            Note selectedNote = (Note)lbAllNotes.SelectedItem;
            noteId = selectedNote.Id;
            DBHelper.DeleteNote(noteId);
            ClearForm();
            LoadNoteList();
        }

        private void lbAllNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonBehaviour();
        }

        private void LoadNoteList()
        {
            //empty list for the notes
            List<Note> notes = new List<Note>();
            //list box behaviour
            lbAllNotes.DisplayMember = "Title";
            lbAllNotes.ValueMember = "Id";
            //select notes from db and populate the list box
            notes = DBHelper.SelectAllNotes();
            lbAllNotes.DataSource = notes;
            //set default: nothing selected
            lbAllNotes.SelectedIndex = -1;
            ButtonBehaviour();
        }
        private void ClearForm()
        {
            tbNoteTitle.Text = "";
            rtbNoteBody.Text = "";
        }

        private void ButtonBehaviour()
        {
            if(lbAllNotes.SelectedIndex == -1)
            {
                //if nothing selected deactivate buttons edit and delete
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                //if something is selected activate buttons
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
