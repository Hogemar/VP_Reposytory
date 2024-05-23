using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App13
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScreenshotPage : ContentPage
    {
        public ScreenshotPage(string imagePath)
        {
            InitializeComponent();

            screenshotImage.Source = ImageSource.FromFile(imagePath);
        }
    }
}