using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _authorService.GetAllAuthor();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {

                return BadRequest(result);
            }
        }

        [HttpGet("getauthorbyid")]
        public IActionResult GetBookById(int id)
        {
            var result = _authorService.GetAuthor(id);
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
        public IActionResult Add(Author author)
        {
            var result = _authorService.Add(author);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
