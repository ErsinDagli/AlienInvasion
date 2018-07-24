
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlienInvasionGame
{
	public partial class MainPage : ContentPage
	{

        

		public MainPage()
		{
            
            InitializeComponent();
           

        }

        private void Theme1_Clicked(object sender, EventArgs e)
        {
            App.Current.Resources["textColor"] = Color.White;
            App.Current.Resources["backgroundColor"] = Color.Turquoise;
        }

        private void Theme2_Clicked(object sender, EventArgs e)
        {
            App.Current.Resources["textColor"] = Color.Black;
            App.Current.Resources["backgroundColor"] = Color.Peru;
        }

        private void Theme3_Clicked(object sender, EventArgs e)
        {
            App.Current.Resources["textColor"] = Color.Red;
            App.Current.Resources["backgroundColor"] = Color.Black;
        }

        private void EscapeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GamePage());
        }

        private void HighScoresPagebutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HighScoresPage());
        }
    }
}
