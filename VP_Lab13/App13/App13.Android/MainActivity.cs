using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Graphics;
using System.IO;
using System.Threading.Tasks;
using static App13.MainPage;
using App13.Droid;
using Xamarin.Forms;
using Android.Content;
using Xamarin.Essentials;
using Android.Media;
using Android.Provider;
using Stream = Android.Media.Stream;
using System.Linq;
using Android.Database;

[assembly: Dependency(typeof(ScreenshotService)), Dependency(typeof(ContactService))]
namespace App13.Droid
{
    [Activity(Label = "YourApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static MainActivity Instance { get; private set; }

        const int RequestContactsId = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            RequestContactsPermission();

            Instance = this;
        }

        void RequestContactsPermission()
        {
            if ((int)Build.VERSION.SdkInt >= 23)
            {
                if (CheckSelfPermission(Android.Manifest.Permission.ReadContacts) != Permission.Granted)
                {
                    RequestPermissions(new string[] { Android.Manifest.Permission.ReadContacts }, RequestContactsId);
                }
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }

    public class ScreenshotService : IScreenshotService
    {
        public async Task<Uri> CaptureAsync()
        {
            var rootView = ((Activity)Forms.Context).Window.DecorView.RootView;
            using var screenshot = Bitmap.CreateBitmap(rootView.Width, rootView.Height, Bitmap.Config.Argb8888);
            var canvas = new Canvas(screenshot);
            rootView.Draw(canvas);

            var imageFileName = "screenshot_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
            var storageDir = Forms.Context.GetExternalFilesDir(Android.OS.Environment.DirectoryPictures);
            var imagePath = System.IO.Path.Combine(storageDir.AbsolutePath, imageFileName);

            using var stream = new FileStream(imagePath, FileMode.Create);
            await screenshot.CompressAsync(Bitmap.CompressFormat.Png, 100, stream);
            stream.Close();

            return new Uri(imagePath); // Создание объекта Uri с помощью конструктора
        }
    }

    public class ContactService : IContactService
    {
        public async Task<string> GetRandomContactAsync()
        {
            return await Task.Run(() =>
            {
                string phoneNumber = null;
                ICursor cursor = null;

                try
                {
                    cursor = Android.App.Application.Context.ContentResolver.Query(ContactsContract.CommonDataKinds.Phone.ContentUri, null, null, null, null);
                    if (cursor != null && cursor.MoveToFirst())
                    {
                        var random = new Random();
                        int count = cursor.Count;
                        int index = random.Next(count);
                        if (cursor.MoveToPosition(index))
                        {
                            phoneNumber = cursor.GetString(cursor.GetColumnIndex(ContactsContract.CommonDataKinds.Phone.Number));
                        }
                    }
                }
                finally
                {
                    cursor?.Close();
                }

                return phoneNumber;
            });
        }
    }


}