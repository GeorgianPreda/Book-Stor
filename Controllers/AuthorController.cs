using Microsoft.AspNetCore.Mvc;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class AuthorController : Controller
    {

        private readonly ApplicationDbContext _db;

        public AuthorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Author> objCategoryList = _db.Authors.ToList();

            return View(objCategoryList);
        }

        //GET
        public IActionResult Create()
        {

            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Author obj)
        {
            if (ModelState.IsValid)
            {
                _db.Authors.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
