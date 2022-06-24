using System;
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

        public static void InsertToDB(string title, string body)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Notes (Title, Body) VALUES(@Title, @Body)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Body", body);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateNoteInDb(int id, string title, string body)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = String.Format("UPDATE Notes SET Title='{0}', Body='{1}' WHERE NoteId='{2}'", title, body, id);
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Note> SelectAllNotesFromDb()
        {
            List<Note> result = new List<Note>();
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

                        result.Add(note);
                    }
                }
            }
            return result;
        }

        public static void DeleteFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = String.Format("DELETE FROM Notes WHERE NoteId='{0}'", id);
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
