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
        
        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookList obj)
        {
            if (obj.Title == obj.Author)
            {
                ModelState.AddModelError("BookList", "Title and Author cannot be same!");
            }
            if(ModelState.IsValid)
            {
                _db.BookList.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id==0)
            {
                return NotFound();
            }
            var objBookList = _db.BookList.Find(id);
            if(objBookList == null)
            {
                return NotFound();
            }
            return View(objBookList);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BookList obj)
        {
            if (obj.Title == obj.Author)
            {
                ModelState.AddModelError("BookList", "Title and Author cannot be same!");
            }
            if(ModelState.IsValid)
            {
                _db.BookList.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        // GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var objBookList = _db.BookList.Find(id);
            if (objBookList == null)
            {
                return NotFound();
            }
            return View(objBookList);
        }
		// POST
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Delete(BookList obj)
		{
			_db.BookList.Remove(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
