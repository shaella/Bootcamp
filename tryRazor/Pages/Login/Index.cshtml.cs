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
    public class IndexModel : PageModel
    {
        private readonly tryRazor.Data.tryRazorContext _context;

        public IndexModel(tryRazor.Data.tryRazorContext context)
        {
            _context = context;
        }

        public IList<Login> Login { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Login != null)
            {
                Login = await _context.Login.ToListAsync();
            }
        }
    }
}
