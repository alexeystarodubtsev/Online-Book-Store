using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Online_book_store.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private Models.ApplicationContext db;

        public BookController(Models.ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public IEnumerable<Models.Author> GetCompanies()
        {
            List<Models.Author>  authors = new List<Models.Author>();
            foreach (var author in db.Authors)
            {
                authors.Add(author);
            }
            return authors;
        }
    }
}
