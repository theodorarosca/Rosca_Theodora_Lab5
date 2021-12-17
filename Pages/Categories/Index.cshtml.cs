using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Roșca_Theodora_Lab5.Data;
using Roșca_Theodora_Lab5.Models;

namespace Roșca_Theodora_Lab5.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Roșca_Theodora_Lab5.Data.Roșca_Theodora_Lab5Context _context;

        public IndexModel(Roșca_Theodora_Lab5.Data.Roșca_Theodora_Lab5Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
