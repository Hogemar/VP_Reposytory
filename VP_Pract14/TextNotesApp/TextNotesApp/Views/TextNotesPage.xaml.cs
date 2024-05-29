using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextNotesApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextNotesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextNotesPage : ContentPage
    {
        string _fileName;
        public TextNotesPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var notes = new List<TextNote>();

            foreach (var filename in Directory.EnumerateFiles(App.FolderPath, "*.notes.txt"))
            {
                var textNote = new TextNote
                {
                    Filename = filename,
                    Text = File.ReadAllText(filename),
                    Date = File.GetCreationTime(filename)
                };

              
                var imagePath = Path.ChangeExtension(filename, ".jpg");
                if (File.Exists(imagePath))
                    textNote.ImagePath = imagePath;

                notes.Add(textNote);
            }

            collectionView.ItemsSource = notes.OrderBy(d => d.Date).ToList();
        }

        async void OnAddClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TextNoteEntryPage));
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                TextNote note = (TextNote)e.CurrentSelection.FirstOrDefault();
                await
               Shell.Current.GoToAsync($"{nameof(TextNoteEntryPage)}?{nameof(TextNoteEntryPage.ItemId)}={note.Filename}");
            }
        }

       


    }
}