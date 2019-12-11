using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace galwaytourism
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AranIslands : ContentPage
	{
		public AranIslands ()
		{
			InitializeComponent ();
            AddImages();
		}
        //method for accessing embedded images
        private void AddImages()
        {
            var assembly = typeof(AranIslands);

            string inisMe = "galwaytourism.Images.inismeain.jpg";
            string inisO= "galwaytourism.Images.inisoirr.jpg";
            string inisMo = "galwaytourism.Images.inismor.jpg";


            inismeainImg.Source = ImageSource.FromResource(inisMe, assembly);
            inisoirrImg.Source = ImageSource.FromResource(inisO, assembly);
            inismorImg.Source = ImageSource.FromResource(inisMo, assembly);
        }

        //setting up a url link on the click of the button
        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.aranisland.info/"));
        }
    }
}