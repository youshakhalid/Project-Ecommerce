using Microsoft.AspNetCore.Mvc.RazorPages;
using Temp.Data;
using Temp.Models;

namespace Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public List<CategoryModel> category { get; set; }
        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public void OnGet()
        {
            category = _dbContext.Categories.ToList();
        }
    }
}
