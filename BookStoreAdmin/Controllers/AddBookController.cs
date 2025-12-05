using Microsoft.AspNetCore.Mvc;

namespace BookStoreAdmin.Controllers
{
    public class AddBookController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Title,string Author,string Subject,string BookSummery)
        {
            return View(); 
        }
    }
}
