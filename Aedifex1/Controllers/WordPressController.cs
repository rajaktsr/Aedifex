using Microsoft.AspNetCore.Mvc;
using WordPressPCL;
using WordPressPCL.Client;

namespace Aedifex1.Controllers
{
    public class WordPressController : Controller
    {
        private readonly WordPressClient _client;

        public WordPressController()
        {
            var wpBaseAddress = new Uri("http://localhost/aedifex/wp-json/");
            _client = new WordPressClient(wpBaseAddress);
        }

        public async Task<IActionResult> Index(int mediaId)
        {
            string message;

            try
            {
                var medias = await _client.Media.GetAllAsync();

                if (medias.Any())
                {
                    message = "Successfully connected to WordPress API!";
                }
                else
                {
                    message = "Connected, but no posts found.";
                }
            }
            catch (Exception ex)
            {
                message = $"Error connecting to WordPress API: {ex.Message}";
            }

            ViewData["ConnectionStatus"] = message;
            return View();
        }
        }
    }
