using BookStoreAdmin.Models.BookStoreDbContext;
using BookStoreAdmin.Models.Entities.Book;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAdmin.Controllers
{
    public class UpdateBookController : Controller
    {
        private readonly BookStoreDbContext _bookStoreDbContext;
        public UpdateBookController(BookStoreDbContext bookStoreDbContext)
        {
            _bookStoreDbContext = bookStoreDbContext;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int Id,string Title, string Author, string Subject, string BookSummery)
        {
            var book = _bookStoreDbContext.Books.FirstOrDefault(b => b.Id == Id);
            if (Title != null) 
            book.Title = Title;
            if(Author != null)
            book.Author = Author;
            if(Subject != null) 
            book.Subject = Subject;
            if(BookSummery != null)
            book.BookSummery = BookSummery;
         
            _bookStoreDbContext.Books.Update(book);
            _bookStoreDbContext.SaveChanges();

            return View();
        }
    }
}
