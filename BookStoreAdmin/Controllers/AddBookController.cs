using BookStoreAdmin.Models.BookStoreDbContext;
using BookStoreAdmin.Models.Entities.Book;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAdmin.Controllers
{
    public class AddBookController : Controller
    {
        private readonly BookStoreDbContext _bookStoreDbContext;
        public AddBookController(BookStoreDbContext bookStoreDbContext)
        {
            _bookStoreDbContext = bookStoreDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Title,string Author,string Subject,string BookSummery)
        {
            Book bk = new Book()
            {
                Title = Title,
                Author = Author,
                Subject = Subject,
                BookSummery = BookSummery
            };
            _bookStoreDbContext.Books.Add(bk);
            _bookStoreDbContext.SaveChanges();
            return View(); 
        }
    }
}
