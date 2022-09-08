using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NoteKeepingApp
{
    internal class DBHelper
    {
        static string connectionString = Properties.Settings.Default.NotesDbConnectionString;
        public static void InsertNote(string title, string body)
        {
            //create connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //open connection
                    connection.Open();
                    //sql
                    string sql = "INSERT INTO Notes (Title, Body) VALUES(@Title, @Body)";
                    //prepare command
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        //add paramenters
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Body", body);
                        //execute
                        command.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public static void UpdateNote(int id, string title, string body)
        {
            //create connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //open connection
                    connection.Open();
                    //sql
                    string sql = "UPDATE Notes SET Title=@title, Body=@body WHERE NoteId=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        //add parameters
                        command.Parameters.Add("@title", SqlDbType.VarChar).Value = title;
                        command.Parameters.Add("@body", SqlDbType.VarChar).Value = body;
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        //execute
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static List<Note> SelectAllNotes()
        {
            //list for the results
            List<Note> notes = new List<Note>();
            //create connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //open connection
                    connection.Open();
                    //sql
                    string sql = "SELECT * FROM Notes";
                    //prepare command
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        //execute
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Note note = new Note();
                                note.Id = reader.GetInt32(0);
                                note.Title = reader.GetString(1);
                                note.Body = reader.GetString(2);

                                notes.Add(note);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            return notes;
        }

        public static Note SelectNote(int id)
        {
            //return value
            Note note = new Note();
            //create connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //open connection
                    connection.Open();
                    //sql
                    string sql = "SELECT * FROM Notes WHERE NoteId=@id";
                    //prepare command
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        //add parameters
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        //execute
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                note.Id = reader.GetInt32(0);
                                note.Title = reader.GetString(1);
                                note.Body = reader.GetString(2);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            return note;
        }

        public static void DeleteNote(int id)
        {
            //create connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //open connection
                    connection.Open();
                    //sql
                    string sql = "DELETE FROM Notes WHERE NoteId=@id";
                    //prepare command
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        //add parameters
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        //execute
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
