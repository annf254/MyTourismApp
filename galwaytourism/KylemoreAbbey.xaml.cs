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
	public partial class KylemoreAbbey : ContentPage
	{
		public KylemoreAbbey ()
		{
			InitializeComponent ();
            AddImages(); 
        }
        //creating method to access the embedded images
        private void AddImages()
        {
            var assembly = typeof(KylemoreAbbey);

            string kylemoregarden = "galwaytourism.Images.kylemorewalledgarden.jpg";
            string kylemorechurch = "galwaytourism.Images.kylemoreabbeychurch.jpg";


            kylemoregardenImg.Source = ImageSource.FromResource(kylemoregarden, assembly);
            kylemorechurchImg.Source = ImageSource.FromResource(kylemorechurch, assembly);
        }

        //creating url link on the click of the button

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri (new Uri("https://www.kylemoreabbey.com/"));
        }
    }
}