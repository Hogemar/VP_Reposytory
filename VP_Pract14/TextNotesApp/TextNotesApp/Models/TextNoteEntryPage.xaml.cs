using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextNotesApp.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextNotesApp.Views
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextNoteEntryPage : ContentPage
    {
        public TextNoteEntryPage()
        {
            InitializeComponent();
            BindingContext = new Models.TextNote();
        }

        public string ItemId
        {
            set { LoadNote(value); }
        }

        void LoadNote(string filename)
        {
            try
            {
                TextNote note = new TextNote()
                {
                    Filename = filename,
                    Text = File.ReadAllText(filename),
                    Date = File.GetCreationTime(filename)
                };

                // Load the associated image path if it exists
                var imageFilename = Path.Combine(App.FolderPath, $"{Path.GetFileNameWithoutExtension(filename)}.jpg");
                if (File.Exists(imageFilename))
                {
                    note.ImagePath = imageFilename;
                }

                BindingContext = note;
            }
            catch (Exception)
            {
                Console.WriteLine("Can't load note");
            }
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (TextNote)BindingContext;
            var isNewNote = string.IsNullOrWhiteSpace(note.Filename);

            if (isNewNote)
            {
                // Generate unique filenames for the note and image
                var noteFilename = Path.Combine(App.FolderPath, $"{Guid.NewGuid()}.notes.txt");
                note.Filename = noteFilename;
            }

            // Save the text note to a file
            File.WriteAllText(note.Filename, note.Text);

            // Save the image if there's a new one added
            if (!string.IsNullOrWhiteSpace(note.ImagePath) && File.Exists(note.ImagePath))
            {
                var imageFilename = Path.Combine(App.FolderPath, $"{Path.GetFileNameWithoutExtension(note.Filename)}.jpg");

                // Copy the new image if it's not already in the desired location or if the image path has changed
                if (isNewNote || note.ImagePath != imageFilename)
                {
                    // Delete the old image file if it exists and the note is not new
                    if (!isNewNote && File.Exists(imageFilename))
                    {
                        File.Delete(imageFilename);
                    }

                    File.Copy(note.ImagePath, imageFilename, overwrite: true);
                    note.ImagePath = imageFilename;
                }

                // Update the image source on the page
                image.Source = ImageSource.FromFile(imageFilename);
            }

            await Shell.Current.GoToAsync("..");
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (TextNote)BindingContext;

            if (File.Exists(note.Filename))
            {
                File.Delete(note.Filename);
            }

            // Delete the associated image file if it exists
            if (!string.IsNullOrWhiteSpace(note.ImagePath) && File.Exists(note.ImagePath))
            {
                File.Delete(note.ImagePath);
            }

            await Shell.Current.GoToAsync("..");
        }

        async void OnAddImageClicked(object sender, EventArgs e)
        {
            try
            {
                var result = await MediaPicker.PickPhotoAsync();
                if (result != null)
                {
                    var imagePath = Path.Combine(App.FolderPath, $"{Guid.NewGuid().ToString()}.jpg");
                    using (var stream = await result.OpenReadAsync())
                    {
                        using (var fileStream = File.Create(imagePath))
                        {
                            await stream.CopyToAsync(fileStream);
                        }
                    }

                    // Update the image path in the TextNote model
                    ((TextNote)BindingContext).ImagePath = imagePath;
                    image.Source = ImageSource.FromFile(imagePath); // Update the image source
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error selecting image: {ex.Message}");
            }
        }
    }
}
