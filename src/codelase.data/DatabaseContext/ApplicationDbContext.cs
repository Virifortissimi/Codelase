using CodeLase.data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeLase.data.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogModel> Blogs { get; set; }
        public DbSet<CommentModel> Comments { get; set; }
    }
}