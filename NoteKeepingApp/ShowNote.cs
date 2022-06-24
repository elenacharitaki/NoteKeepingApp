using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteKeepingApp
{
    public partial class ShowNote : Form
    {
        private int NoteId { get; }

        public ShowNote()
        {
            InitializeComponent();
        }

        public ShowNote(int id)
        {
            InitializeComponent();
            NoteId = id;
        }

        private void ShowNote_Load(object sender, EventArgs e)
        {
            Note note = DBHelper.SelectFromDb(NoteId);
            lblShowTitle.Text = note.Title;
            lblShowBody.Text = note.Body;

            lblShowTitle.BackColor = Color.White;
            lblShowBody.BackColor = Color.White;

            lblShowTitle.BorderStyle = BorderStyle.Fixed3D;
            lblShowBody.BorderStyle = BorderStyle.Fixed3D;

            lblShowTitle.AutoSize = true;
            lblShowBody.AutoSize = true;
        }
    }
}
