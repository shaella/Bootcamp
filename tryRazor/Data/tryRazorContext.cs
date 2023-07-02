using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tryRazor;

namespace tryRazor.Data
{
    public class tryRazorContext : DbContext
    {
        public tryRazorContext (DbContextOptions<tryRazorContext> options)
            : base(options)
        {
        }

        public DbSet<tryRazor.Login> Login { get; set; } = default!;
    }
}
