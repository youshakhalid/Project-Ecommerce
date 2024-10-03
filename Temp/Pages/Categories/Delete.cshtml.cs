using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Temp.Data;
using Temp.Models;

namespace Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CategoryModel category {  get; set; }
        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet(int ?Id)
        {
            if (Id != null && Id != 0)
            {
                category = _context.Categories.FirstOrDefault(u => u.Id == Id);
            }
           
        }

        public IActionResult OnPost()
        {
            CategoryModel? categoryId = _context.Categories.Find(category.Id);
            if (categoryId == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(categoryId);
            _context.SaveChanges();
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToPage("Index"); 
        }
    }
}
