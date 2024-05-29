using System;
using System.Collections.Generic;
using TextNotesApp.Views;
using Xamarin.Forms;

namespace TextNotesApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TextNoteEntryPage), typeof(TextNoteEntryPage));

        }

    }
}
