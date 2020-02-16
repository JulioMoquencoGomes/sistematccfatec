using Microsoft.EntityFrameworkCore;
using Domain.Entities;
namespace Infrastructure.Context
{
    public class WebContext : DbContext
    {
        public WebContext(DbContextOptions<WebContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
    }
}