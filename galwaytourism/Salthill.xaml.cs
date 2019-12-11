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
	public partial class Salthill : ContentPage
	{
		public Salthill ()
		{
			InitializeComponent ();
            AddImages();
		}

        //accessing embedded images
        private void AddImages()
        {
            var assembly = typeof(AranIslands);

            string salthillbeach = "galwaytourism.Images.salthillbeach.jpg";
            string salthillprom= "galwaytourism.Images.salthillprom.jpg";
            string blackrockDiv = "galwaytourism.Images.blackrockdivingboard.jpg";


            salthillbeachImg.Source = ImageSource.FromResource(salthillbeach, assembly);
            salthillpromImg.Source = ImageSource.FromResource(salthillprom, assembly);
            blackrockdivingboardImg.Source = ImageSource.FromResource(blackrockDiv, assembly);
        }

        //creating url link on the click of the button

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.discoverireland.ie/Arts-Culture-Heritage/the-salthill-promenade/81207"));
        }
    }
}