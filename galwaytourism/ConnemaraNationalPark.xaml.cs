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
	public partial class ConnemaraNationalPark : ContentPage
	{
		public ConnemaraNationalPark ()
		{
			InitializeComponent ();
            AddImages();
		}
         //method for accessing embedded images 
        private void AddImages()
        {
            var assembly = typeof(ConnemaraNationalPark);

            string connNP = "galwaytourism.Images.connemaraNP.jpg";
            string diamondHill = "galwaytourism.Images.diamondhill.jpg";
            


            connemaraNPImg.Source = ImageSource.FromResource(connNP, assembly);
            diamondhillImg.Source = ImageSource.FromResource(diamondHill, assembly);
            
        }

        //creating url link on the click of a button

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.connemaranationalpark.ie/"));
        }
    }
}