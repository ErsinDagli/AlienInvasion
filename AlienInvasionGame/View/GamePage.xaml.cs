
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
    public partial class GamePage : ContentPage 
    {


        static string alien = "Door" + " " + new Random().Next(1, 4).ToString();
        static int Score;
        public static int HighScore;

        //Constructor
        public GamePage()
        {
            InitializeComponent();
            


        }





        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            //Game Over
            if (button.Text == alien)
            {
                //var alienFace = new Image { Source = "alien.png" };
                await Application.Current.MainPage.DisplayAlert("Oh no!", "An Alien has caught you!", "Try again");
                alien = "Door" + " " + new Random().Next(1, 4).ToString();


                if (Application.Current.Properties.ContainsKey("High Score"))
                {

                    HighScore = (int)Application.Current.Properties["High Score"];
                }
                else
                {
                    
                    Application.Current.Properties.Add("High Score", HighScore);
                    HighScore = (int)Application.Current.Properties["High Score"];
                }
                


                //Save high score in app IF the Alien has been found.
                if (Score < HighScore)
                {
                    Score = 0;
                }
                else if (Score > HighScore)
                {
                    Application.Current.Properties["High Score"] = Score;
                    Score = 0;


                }

            }
            else
            {
                Score += 100;
                string ScoreString = Score.ToString();
                await Application.Current.MainPage.DisplayAlert("New score", $"{ScoreString}", "Ok");
                alien = "Door" + " " + new Random().Next(1, 4).ToString();





            }

        }
    }
}