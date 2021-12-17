using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Roșca_Theodora_Lab5.Data;
using Roșca_Theodora_Lab5.Models;

namespace Roșca_Theodora_Lab5.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Roșca_Theodora_Lab5.Data.Roșca_Theodora_Lab5Context _context;

        public CreateModel(Roșca_Theodora_Lab5.Data.Roșca_Theodora_Lab5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
