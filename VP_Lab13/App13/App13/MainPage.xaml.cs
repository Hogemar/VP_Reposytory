using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;


namespace App13
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			UpdateBatteryInfo();
			Battery.BatteryInfoChanged += OnBatteryInfoChanged;

			DisplayDeviceInfo();

			DisplayDisplayInfo();
		}

		/// Информация о батарее
		private void UpdateBatteryInfo()
		{
			BatteryLabel.Text =
				"\tBATTERY\n" +
				$"Level: {Battery.ChargeLevel * 100}%\n" +
				$"State: {Battery.State}\n" +
				$"Source: {Battery.PowerSource}";
		}
		private void OnBatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
		{
			UpdateBatteryInfo();
		}

		/// Информация об устройстве
		private void DisplayDeviceInfo()
		{
			DeviceInfoLabel.Text =
				"\tDEVICE\n" +
				$"Manufacturer: {DeviceInfo.Manufacturer}\n" +
				$"Model: {DeviceInfo.Model}\n" +
				$"Version: {DeviceInfo.VersionString}\n" +
				$"Platform: {DeviceInfo.Platform}\n" +
				$"Idiom: {DeviceInfo.Idiom}";
		}

		/// Информация о дисплее
		private void DisplayDisplayInfo()
		{
			var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

			DisplayInfoLabel.Text =
				"\tDISPLAY\n" +
				$"Density: {mainDisplayInfo.Density}\n" +
				$"Orientation: {mainDisplayInfo.Orientation}\n" +
				$"Rotation: {mainDisplayInfo.Rotation}\n" +
				$"Width: {mainDisplayInfo.Width}\n" +
				$"Height: {mainDisplayInfo.Height}";
		}

		/// Кнопка фонарика
		private bool isFlashlightOn = false;
		private async void OnToggleFlashlightClicked(object sender, EventArgs e)
		{
			try
			{
				if (isFlashlightOn)
					await Flashlight.TurnOffAsync();
				else
					await Flashlight.TurnOnAsync();

				isFlashlightOn = !isFlashlightOn;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// Мигать фонариком
		private bool isFlashlightBlinking = false;
		private CancellationTokenSource cts;
		private async void OnToggleBlinkingClicked(object sender, EventArgs e)
		{
			if (isFlashlightBlinking)
			{
				cts?.Cancel();
				ToggleBlinkButton.Text = "Start Flashlight Blink";
			}
			else
			{
				cts = new CancellationTokenSource();
				ToggleBlinkButton.Text = "Stop Flashlight Blink";
				BlinkFlashlight(cts.Token);
			}

			isFlashlightBlinking = !isFlashlightBlinking;
		}
		private async Task BlinkFlashlight(CancellationToken token)
		{
			try
			{
				while (!token.IsCancellationRequested)
				{
					await Flashlight.TurnOnAsync();
					await Task.Delay(1000);
					await Flashlight.TurnOffAsync();
					await Task.Delay(1000);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// Скриншот
		public interface IScreenshotService
		{
			Task<Uri> CaptureAsync();
		}
		private async void OnMakeScreenshotClicked(object sender, EventArgs e)
		{
			try
			{
				var screenshotService = DependencyService.Get<IScreenshotService>();

				if (screenshotService == null)
				{
					Console.WriteLine("Сервис захвата скриншота не доступен");
					return;
				}

				var screenshotPath = await screenshotService.CaptureAsync();

				var screenshotPage = new ScreenshotPage(screenshotPath.AbsolutePath);

				// Обертываем новую страницу в NavigationPage, чтобы можно было управлять навигацией
				var navigationPage = new NavigationPage(screenshotPage);

				// Переходим на страницу с скриншотом с использованием NavigationPage
				await Navigation.PushModalAsync(navigationPage);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка при создании скриншота: " + ex.Message);
			}
		}

		/// Случайный контакт
		private async void OnGetRandomContactClicked(object sender, EventArgs e)
		{
			var phoneNumber = await DependencyService.Get<IContactService>().GetRandomContactAsync();
			if (!string.IsNullOrEmpty(phoneNumber))
			{
				PhoneDialer.Open(phoneNumber);
			}
			else
			{
				await DisplayAlert("Error", "No contacts found or no phone number available.", "OK");
			}
		}
		public interface IContactService
		{
			Task<string> GetRandomContactAsync();
		}

		/// Камера 
		private async void OnTakePhotoClicked(object sender, EventArgs e)
		{
			try
			{
				var photo = await MediaPicker.CapturePhotoAsync();
				if (photo == null)
					return;

				var stream = await photo.OpenReadAsync();
				var imageSource = ImageSource.FromStream(() => stream);

				PhotoImage.Source = imageSource;

			}
			catch (FeatureNotSupportedException fnsEx)
			{
				// Feature is not supported on the device
				await DisplayAlert("Error", "Camera is not supported on this device.", "OK");
			}
			catch (PermissionException pEx)
			{
				// Permissions not granted
				await DisplayAlert("Error", "Camera permission is not granted.", "OK");
			}
			catch (Exception ex)
			{
				// Other errors
				await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
			}
		}


	}



}
