using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BulkyWeb.Controllers {
    public class CategoryController : Controller {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db){
            _db = db;
        }
        public IActionResult Index() {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create() {
            return View();  
        }
        [HttpPost]
        public IActionResult Create(Category obj) {

            
            
            
            
            if (obj.Name != null && obj.Name.ToLower() == "test") {
                ModelState.AddModelError("", "Test is invalid name");
            }

            //if (obj.Name == obj.DisplayOrder.ToString()) {
            //    ModelState.AddModelError("name", "The DisplayOrder value cannot exactly match the Name");
            //} 
            
            
            //if (obj.DisplayOrder == null) {
            //    ModelState.AddModelError("DisplayOrder", "You have to enter a value in Display Order field");
            //}

            if (ModelState.IsValid) {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
            
        }
    }
}
