using ASP.NET_MVC_CRUD_APP.Data;
using ASP.NET_MVC_CRUD_APP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC_CRUD_APP.Controllers
{
    public class BookListController : Controller
    {

        public readonly AppDbContext _db;

        public BookListController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<BookList> objBookList = _db.BookList;
            return View(objBookList);
        }
    }
}
