using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;
using LibraryManagement.Services;

namespace LibraryManagement.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        public LibraryController()
        {
        }

        // GET all action
        [HttpGet]
        public ActionResult<List<Library>> GetAll() =>
        LibraryService.GetAll();

        // GET by Id action
        [HttpGet("{bookid}")]
        public ActionResult<Library> Get(int bookid)
        {
            var library = LibraryService.Get(bookid);

            if (library == null)
                return NotFound();

            return library;
        }

        // POST action
        [HttpPost]
        public IActionResult Create(Library library)
        {
            LibraryService.Add(library);
            return CreatedAtAction(nameof(Create), new { bookid = library.bookId }, library);
        }


        // PUT action
        [HttpPut("{bookid}")]
        public IActionResult Update(int bookid, Library library)
        {
            if (bookid != library.bookId)
                return BadRequest();

            var existingLibrary = LibraryService.Get(bookid);
            if (existingLibrary is null)
                return NotFound();

            LibraryService.Update(library);

            return NoContent();
        }

        // DELETE action
        [HttpDelete("{bookid}")]
        public IActionResult Delete(int bookid)
        {
            var library = LibraryService.Get(bookid);

            if (library is null)
                return NotFound();

            LibraryService.Delete(bookid);

            return NoContent();
        }
    }
}