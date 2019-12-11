using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace galwaytourism
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AddImages();
        }
        private void AddImages()
        {
            var assembly = typeof(MainPage);

            /*access the image file within the assembly*/
            string kylemoreAbbey = "galwaytourism.Images.kylemoreabbey.jpg";
            string aranIslands = "galwaytourism.Images.aranislands.jpg";
            string salthill = "galwaytourism.Images.Salthill.jpg";
            string connemaraNationalPark = "galwaytourism.Images.connemaranationalpark.jpg";
         



            kylemoreAbbeyBtn.Source = ImageSource.FromResource(kylemoreAbbey, assembly);
            aranislandsBtn.Source = ImageSource.FromResource(aranIslands, assembly);
            SalthillBtn.Source = ImageSource.FromResource(salthill, assembly);
            connemaranationalparkBtn.Source = ImageSource.FromResource(connemaraNationalPark, assembly);
            
        }

        //on the click of the button an alert message will pop up

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotesPage());
            await DisplayAlert("Alert", "Click the + symbol on the Toolbar to enter a note.", "OK");
        }

        //opening kylemore abbey class
        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KylemoreAbbey());
        }

        //opening Aran Islands Class

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AranIslands());
        }

        //opening Salthill Class
        private async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Salthill());
        }

        //opening connemara national park class
        private async void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConnemaraNationalPark());
        }

        
    }
}
