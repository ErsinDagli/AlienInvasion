
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlienInvasionGame
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HighScoresPage : ContentPage
	{

       


        public HighScoresPage ()
		{
			InitializeComponent ();
            Blink();

            if (Application.Current.Properties.ContainsKey("High Score"))
            {
                HighScoreLabel.Text = Application.Current.Properties["High Score"].ToString();
            }
            else
            {
                Application.Current.Properties.Add("High Score", GamePage.HighScore);
            }
          
           

        }


        


        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                HighScoreTag.BackgroundColor = HighScoreTag.BackgroundColor == Color.Red ? Color.Green : Color.Red;
            }
        }

   

       
    }
}