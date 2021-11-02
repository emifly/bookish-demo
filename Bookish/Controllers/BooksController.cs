using Bookish.Models.View;
using Bookish.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bookish.Controllers
{
    [Route("/books")]
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet("")]
        public IActionResult ViewAll()
        {
            var books = _booksService.GetAllBooks();
            var viewModel = new BooksViewModel { Books = books };
            return View(viewModel);
        }
    }
}