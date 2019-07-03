using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ej_backend.Services;
using ej_backend.Model;

namespace ej_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService bookService;
        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IList<Book>> Get()
        {
            return bookService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            return bookService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            bookService.Save(book);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book book)
        {
            bookService.Save(book);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            bookService.Delete(id);
        }
    }
}