using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Temp.Data;
using Temp.Models;

namespace Temp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CategoryModel category { get; set; }
        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet(int ?id)
        {
            if (id != 0 && id != null)
            {
                category = _context.Categories.FirstOrDefault(u => u.Id == id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid) 
            { 
                _context.Categories.Update(category);
                _context.SaveChanges();
                TempData["success"] = "Category Edited Successfully";
                return RedirectToPage("Index");
            }
            return RedirectToPage("Index");
        }
    }
}
