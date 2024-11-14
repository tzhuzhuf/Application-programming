using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteList
{
    public class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }

        public Note(string title, string content, string category)
        {
            Title = title;
            Content = content;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Title} ({Category})";
        }
    }
}
