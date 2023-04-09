using ASP.NET_MVC_CRUD_APP.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC_CRUD_APP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<BookList> BookList { get; set; }
    }
}
