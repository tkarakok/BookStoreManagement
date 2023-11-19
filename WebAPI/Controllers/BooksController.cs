using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bookService.GetAllBooks();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {

                return BadRequest(result);
            }
        }

        [HttpGet("getbookbyid")]
        public IActionResult GetBookById(int id)
        {
            var result = _bookService.GetBookById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {

                return BadRequest(result);
            }
        }

        [HttpGet("getallbookdetails")]
        public IActionResult GetAllBookDetails()
        {
            var result = _bookService.GetBookDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {

                return BadRequest(result);
            }
        }

        [HttpPost("add")]
        public IActionResult Add(Book book)
        {
            var result = _bookService.Add(book);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
