using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Roșca_Theodora_Lab5.Data;
using Roșca_Theodora_Lab5.Models;

namespace Roșca_Theodora_Lab5.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Roșca_Theodora_Lab5.Data.Roșca_Theodora_Lab5Context _context;

        public DetailsModel(Roșca_Theodora_Lab5.Data.Roșca_Theodora_Lab5Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
