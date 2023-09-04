using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class WebApplication3DbContext : DbContext
    {
        public WebApplication3DbContext (DbContextOptions<WebApplication3DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication3.Models.Task> Task { get; set; } = default!;
    }
}
