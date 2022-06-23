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
        public Home()
        {
            InitializeComponent();
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            noteTitle = tbNoteTitle.Text;
            noteBody = rtbNoteBody.Text;

            insertToDB(noteTitle, noteBody);
        }

        private void insertToDB(string noteTitle, string noteBody)
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
        }
    }
}
