using Microsoft.AspNetCore.Mvc;
using StudentDB_Practice.Data;
using StudentDB_Practice.Models;

namespace StudentDB_Practice.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            _context.Categories.Add(category);
            _context.SaveChanges();

            return Content($"Category saved! ID = {category.Id}");
        }
    }

        
}
