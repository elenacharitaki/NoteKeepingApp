﻿using System;
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
                UpdateNoteInDb(noteId, noteTitle, noteBody);
                update = false;
            }
            else
            {
                InsertToDB(noteTitle, noteBody);
            }
            
            tbNoteTitle.Text = "";
            rtbNoteBody.Text = "";
        }

        private void InsertToDB(string noteTitle, string noteBody)
        {
            string connectionString = Properties.Settings.Default.NotesDbConnectionString;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Notes (Title, Body) VALUES(@Title, @Body)";
                using( SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Title", noteTitle);
                    command.Parameters.AddWithValue("@Body", noteBody);
                    command.ExecuteNonQuery();
                }
            }
            LoadNoteList();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadNoteList();
        }

        private void LoadNoteList()
        {
            List<Note> notes = new List<Note>();
            lbAllNotes.DisplayMember = "Title";
            lbAllNotes.ValueMember = "Id";

            string connectionString = Properties.Settings.Default.NotesDbConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Notes";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Note note = new Note();
                        note.Id = reader.GetInt32(0);
                        note.Title = reader.GetString(1);
                        note.Body = reader.GetString(2);

                        notes.Add(note);
                    }
                    lbAllNotes.DataSource = notes;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Note selectedNote = (Note)lbAllNotes.SelectedItem;
            noteId = selectedNote.Id;
            tbNoteTitle.Text = selectedNote.Title;
            rtbNoteBody.Text = selectedNote.Body;
            update = true;
        }

        private void UpdateNoteInDb(int id, string title, string body)
        {
            string connectionString = Properties.Settings.Default.NotesDbConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = String.Format("UPDATE Notes SET Title='{0}', Body='{1}' WHERE NoteId='{2}'", title, body, id);
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
                LoadNoteList();
            }
        }
    }
}
