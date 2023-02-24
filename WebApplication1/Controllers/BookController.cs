using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Service.Interface;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result =await _bookService.GetAll();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(string bookName,decimal price,string category)
        {
            await _bookService.Create(bookName, price, category);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, decimal price, string bookName, string category)
        {
            var result = await _bookService.Update(id,price, bookName, category);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Remove(int id)
        {
            var result = await _bookService.Delete(id);
                if (result==false)
                    return NotFound();
                
            return Ok(result);
        }
        [HttpGet("Id")]
        public async Task<IActionResult> GetId(int id)
        {
            var result = await _bookService.GetId(id);
            return Ok(result);
        }
    }
}
