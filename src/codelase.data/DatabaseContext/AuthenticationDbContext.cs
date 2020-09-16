using Microsoft.EntityFrameworkCore;

namespace CodeLase.data.DatabaseContext
{
    public class AuthenticationDbContext : DbContext
    {
        public AuthenticationDbContext(
            DbContextOptions<AuthenticationDbContext> options)
            : base(options)
        {
        }
    }
}