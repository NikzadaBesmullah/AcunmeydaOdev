using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotDefteriWeb.Models
{
    public class Note
    {
        public int Noteid { get; set; }
        public string NoteTitle { get; set; }
        public string NoteContent { get; set; }
        public DateTime NoteAddTime { get; set; }
    }
}