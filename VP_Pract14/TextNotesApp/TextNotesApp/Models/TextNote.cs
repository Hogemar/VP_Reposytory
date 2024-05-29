using System;
using System.Collections.Generic;
using System.Text;

namespace TextNotesApp.Models
{
    internal class TextNote
    {
        public string Filename { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string ImagePath { get; set; }
    }
}
