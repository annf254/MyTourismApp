using galwaytourism.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace galwaytourism
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotesEntryPage : ContentPage
	{
		public NotesEntryPage ()
		{
			InitializeComponent ();
		}
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Notes)BindingContext;

            if (string.IsNullOrWhiteSpace(note.Filename))
            {
                //Save the entry
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);
            }
            else
            {
                //Update the entry
                File.WriteAllText(note.Filename, note.Text);
            }

            await Navigation.PopAsync();
            await DisplayAlert("Tool Tip", "Click the + symbol on Toolbar to enter a note", "OK");
        }

        //method for the delete button
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Notes)BindingContext;

            if (File.Exists(note.Filename))
            {
                File.Delete(note.Filename);
            }

            await Navigation.PopAsync();
            await DisplayAlert("Tool Tip", "Click the + symbol on Toolbar to enter a note", "OK");
        }

        //navigation to main page
        private async void MainPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}