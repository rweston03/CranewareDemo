using CraneWareDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace CraneWareDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        public List<Book> BookList = new List<Book>();
        private Book book1 = new Book(1, "The Handmaid's Tale", "Margaret Atwood");
        private Book book2 = new Book(2, "1984", "George Orwell");
        private Book book3 = new Book(3, "Good Omens", "Neil Gaiman");
        private Book book4 = new Book(4, "Frankenstein", "Mary Shelley");
        private Book book5 = new Book(5, "The Gunslinger", "Stephen King");
        private Book book6 = new Book(6, "The Martian Chronicles", "Ray Bradbury");

        public BookController()
        {
            BookList.Add(book1);
            BookList.Add(book2);
            BookList.Add(book3);
            BookList.Add(book4);
            BookList.Add(book5);
            BookList.Add(book6);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        public async Task<IActionResult> OnGet() => Json(BookList);


        [HttpGet("{id}")]
        public async Task<IActionResult> OnGet(int id)
        {
            return Json(new { data = BookList });
        }
    }
}

