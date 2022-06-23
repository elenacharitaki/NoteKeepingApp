using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeepingApp
{
    internal class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }


        public Note() { }

        public Note(int id, string title, string body)
        {
            Id = id;
            Title = title;
            Body = body;
        }
    }

}
