using CifrOblako1.AppDb;
using CifrOblako1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CifrOblako1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            if (!User.IsInRole(WebConst.AdminRole))
            {
                return NotFound();
            }
            IEnumerable<Product> objList = _db.Product;
            return View(objList);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            if (!User.IsInRole(WebConst.AdminRole))
            {
                return NotFound();
            }
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product obj)
        {
            if (!User.IsInRole(WebConst.AdminRole))
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Product.Add(obj);
                _db.SaveChanges();
            }
            return View();
        }

        // GET: ProductController/Edit/5
        public IActionResult Edit(int? id)
        {
            if (!User.IsInRole(WebConst.AdminRole))
            {
                return NotFound();
            }
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Product.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product obj)
        {
            if (!User.IsInRole(WebConst.AdminRole))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Product.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: ProductController/Delete/5
        public IActionResult Delete(int? id)
        {
            if (!User.IsInRole(WebConst.AdminRole))
            {
                return NotFound();
            }

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Product.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            if (!User.IsInRole(WebConst.AdminRole))
            {
                return NotFound();
            }

            var obj = _db.Product.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            _db.Product.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
