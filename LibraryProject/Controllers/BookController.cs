
using Library.DataAccess.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.Controllers
{
    public class BookController : Controller
    {


        private readonly ApplicationDbContext _db;
        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            List<Book> objBooksList = _db.Books.ToList();
            return View(objBooksList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {

            if (ModelState.IsValid)
            {
                _db.Books.Add(book);
                _db.SaveChanges();
                TempData["success"]= "Kitap Başarıyla Eklendi";
                return RedirectToAction("Index");

            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Book bookFromDb = _db.Books.Find(id);
            if (bookFromDb == null)
            {
                return NotFound();

            }
            return View(bookFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {

            if (ModelState.IsValid)
            {
                _db.Books.Update(book);
                _db.SaveChanges();
                TempData["success"] = "Kitap Başarıyla Güncellendi";

                return RedirectToAction("Index");

            }

            return View();
        }




        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Book? bookFromDb = _db.Books.Find(id);
            if (bookFromDb == null)
            {
                return NotFound();

            }
            return View(bookFromDb);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Book book = _db.Books.Find(id);
            if (book == null) 
            { 
                return NotFound();  
            }
            _db.Books.Remove(book);
            _db.SaveChanges();
            TempData["success"] = "Kitap Başarıyla Silindi";

            return RedirectToAction("Index");

           
        }

    }
}
