using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace VP_Pract13
{
    public partial class MainPage : ContentPage
    {

        List<string> buttonTexts = new List<string> { "Теперь я здесь!", "Поймай меня!", "Нажми еще раз!", "Где я?" };
        public MainPage()
        {
            InitializeComponent();
        }

        Color GetRandomColor()
        {
            Random rnd = new Random();
            return Color.FromRgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }

        string GetRandomText()
        {
            Random rndText = new Random();
            return buttonTexts[rndText.Next(buttonTexts.Count)];
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            //  размеры экрана
            double screenWidth = Application.Current.MainPage.Width;
            double screenHeight = Application.Current.MainPage.Height;

            //  случайные координаты для кнопки
            Random rnd = new Random();
            double newX = rnd.NextDouble() * (screenWidth - button.Width);
            double newY = rnd.NextDouble() * (screenHeight - button.Height);

            //  новые координаты для кнопки
            button.TranslateTo(newX, newY, 550, Easing.Linear);

            button.Text=GetRandomText();
            
            button.BackgroundColor = GetRandomColor();
        }
    }
}

