#region using
using BookStoreAdmin.Models.BookStoreDbContext;
using BookStoreAdmin.Models.Entities.Book;
using Microsoft.AspNetCore.Mvc;
    namespace BookStoreAdmin.Controllers
#endregion

{
    public class ReportBookController : Controller
    {
        //di 
        private readonly BookStoreDbContext _bookStoreDbContext;
        public ReportBookController(BookStoreDbContext bookStoreDbContext)
        {
            _bookStoreDbContext = bookStoreDbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Book> bk = _bookStoreDbContext.Books.ToList();
            return View();
        }
    }
}
