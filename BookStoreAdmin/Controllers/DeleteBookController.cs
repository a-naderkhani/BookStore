using BookStoreAdmin.Models.BookStoreDbContext;
using BookStoreAdmin.Models.Entities.Book;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BookStoreAdmin.Controllers
{
    public class DeleteBookController : Controller
    {
        private readonly BookStoreDbContext _bookStoreDbContext;
        public DeleteBookController(BookStoreDbContext bookStoreDbContext)
        {
            _bookStoreDbContext = bookStoreDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(int Id)
        {
            Book? bk= await _bookStoreDbContext.Books.FirstOrDefaultAsync(x => x.Id == Id);
            _bookStoreDbContext.Books.Remove(bk);
            _bookStoreDbContext.SaveChanges();
            return View();
        }
    }
}
