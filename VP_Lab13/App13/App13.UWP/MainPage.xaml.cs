using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Capture;
using Windows.Graphics.DirectX;
using Windows.Graphics.Display;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms;
using static App13.MainPage;
using Windows.Graphics.DirectX.Direct3D11;

[assembly: Dependency(typeof(IScreenshotService))]
namespace App13.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new App13.App());
        }
    }

    public class ScreenshotService : IScreenshotService
    {
        public async Task<Uri> CaptureAsync()
        {
            var rootElement = Window.Current.Content as FrameworkElement;
            var bitmap = new RenderTargetBitmap();
            await bitmap.RenderAsync(rootElement, (int)rootElement.ActualWidth, (int)rootElement.ActualHeight);
            var buffer = await bitmap.GetPixelsAsync();
            StorageFile storageFile = await ApplicationData.Current.LocalFolder.CreateFileAsync("Screenshot.png", CreationCollisionOption.ReplaceExisting);
            using (Stream stream = await storageFile.OpenStreamForWriteAsync())
            {
                BitmapEncoder encoder = await BitmapEncoder.CreateAsync(BitmapEncoder.PngEncoderId, (IRandomAccessStream)stream);
                encoder.SetPixelData(BitmapPixelFormat.Bgra8, BitmapAlphaMode.Ignore, (uint)bitmap.PixelWidth, (uint)bitmap.PixelHeight, 96, 96, buffer.ToArray());
                await encoder.FlushAsync();
            }
            return new Uri(storageFile.Path); // Создаем объект Uri с помощью конструктора
        }
    }


}
