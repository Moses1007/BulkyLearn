using BulkyLearn.Data;
using BulkyLearn.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyLearn.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db= db;
        }
        public IActionResult Index()
        {
            List<Category> list = _db.Categories.ToList();

            return View(list);
        }

        public IActionResult Create()
        {
            

            return View();
        }
    }
}
