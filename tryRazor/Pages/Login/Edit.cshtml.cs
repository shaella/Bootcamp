using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tryRazor;
using tryRazor.Data;

namespace tryRazor.Pages_Login
{
    public class EditModel : PageModel
    {
        private readonly tryRazor.Data.tryRazorContext _context;

        public EditModel(tryRazor.Data.tryRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Login Login { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Login == null)
            {
                return NotFound();
            }

            var login =  await _context.Login.FirstOrDefaultAsync(m => m.Id == id);
            if (login == null)
            {
                return NotFound();
            }
            Login = login;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Login).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginExists(Login.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LoginExists(int id)
        {
          return (_context.Login?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
