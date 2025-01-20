using Microsoft.AspNetCore.Mvc;
using WordPressPCL;

namespace Aedifex1.Controllers
{
    public class AboutUsController : Controller
    {
        
        private readonly WordPressClient _client;

        public AboutUsController()
        {
            var wpBaseAddress = new Uri("http://localhost/aedifex/wp-json/");
            _client = new WordPressClient(wpBaseAddress);
        }

        public async Task<IActionResult> Index(int mediaId)
        {
            try
            {
                var media = await _client.Media.GetByIDAsync(33);

                return View(media);
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error fetching media: " + ex.Message;
                return View();
            }
        }
    }
}
