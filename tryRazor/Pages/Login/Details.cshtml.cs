using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tryRazor;
using tryRazor.Data;

namespace tryRazor.Pages_Login
{
    public class DetailsModel : PageModel
    {
        private readonly tryRazor.Data.tryRazorContext _context;

        public DetailsModel(tryRazor.Data.tryRazorContext context)
        {
            _context = context;
        }

      public Login Login { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Login == null)
            {
                return NotFound();
            }

            var login = await _context.Login.FirstOrDefaultAsync(m => m.Id == id);
            if (login == null)
            {
                return NotFound();
            }
            else 
            {
                Login = login;
            }
            return Page();
        }
    }
}
