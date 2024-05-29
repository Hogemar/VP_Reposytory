using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;
using System.IO;
using System.Linq;

namespace WebImageEditor.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public async Task<IActionResult> OnPostAsync()
		{
			var request = HttpContext.Request;
			var file = request.Form.Files.FirstOrDefault();
			if (file == null)
			{
				_logger?.LogError("Файла нет");
				return Content("Error: Файла нет");
			}
			var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
			Directory.CreateDirectory(uploadPath);
			var fullPath = Path.Combine(uploadPath, file.FileName);

			using (var fileStream = new FileStream(fullPath, FileMode.Create))
			{
				await file.CopyToAsync(fileStream);
			}
			var relativePath = $"/uploads/{file.FileName}";
			return Content(relativePath);
		}


		public IActionResult OnGetApplyFilter(string filter, string imageUrl)
		{
			try
			{
				if (_logger == null) { Console.WriteLine("А где картиночка?"); }

				if (string.IsNullOrWhiteSpace(imageUrl))
				{
					_logger?.LogError("Файла нет");
					return Content("Error: Файла нет");
				}

				var webRoot = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
				var fullPath = Path.Combine(webRoot, imageUrl.TrimStart('/'));
				if (!System.IO.File.Exists(fullPath))
				{
					_logger?.LogError($"Файла нет: {fullPath}");
					return Content("Error: Файла нет");
				}

				using (var image = SixLabors.ImageSharp.Image.Load<Rgba32>(fullPath))
				{
					_logger?.LogInformation($"Примененние фильтра: {filter}");

					switch (filter.ToLower())
					{
						case "sharpen":
							image.Mutate(x => x.GaussianSharpen());
							break;
						case "blur":
							image.Mutate(x => x.GaussianBlur());
							break;
						case "edge":
							image.Mutate(x => x.DetectEdges());
							break;
						case "left":
							image.Mutate(x => x.Rotate(RotateMode.Rotate270));
							break;
						case "right":
							image.Mutate(x => x.Rotate(RotateMode.Rotate90));
							break;
						default:
							_logger?.LogError($"Unknown filter: {filter}");
							return Content("Error: Unknown filter.");
					}

					var modifiedImagePath = Path.Combine(webRoot, "uploads", $"modified_{Path.GetFileName(fullPath)}");

					_logger?.LogInformation($"Сохранение модифицированого изображения в: {modifiedImagePath}");

					image.Save(modifiedImagePath);

					var relativeModifiedPath = $"/uploads/modified_{Path.GetFileName(fullPath)}";
					return Content(relativeModifiedPath);
				}
			}
			catch (Exception ex)
			{
				_logger?.LogError(ex, "Ошибка применения фильтра");
				return Content($"Error: {ex.Message}");
			}
		}
	}
}
