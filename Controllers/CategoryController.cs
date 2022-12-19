using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tp1.data;
using tp1.Models;

namespace tp1.Controllers
{
    public class CategoryController : Controller

    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: CategoryController
        public ActionResult Index()
        {
            var objCategoryList = _db.categories.ToList();
            return View(objCategoryList);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category obj)
        {
            _db.categories.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


        // GET
        public ActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var CategoryFromDb = _db.categories.Find(id);

            if (CategoryFromDb == null)
            {
                return NotFound();
            }
            return View(CategoryFromDb);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category obj)
        {
            _db.categories.Update(obj);
            _db.SaveChanges();


            return View(obj);

        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var CategoryFromDb = _db.categories.Find(id);

            if (CategoryFromDb == null)
            {
                return NotFound();
            }
            return View(CategoryFromDb);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int? id)
        {
            var obj = _db.categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.categories.Remove(obj);
            _db.SaveChanges();
            TempData["Success"] = "flight deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
 
            
    
