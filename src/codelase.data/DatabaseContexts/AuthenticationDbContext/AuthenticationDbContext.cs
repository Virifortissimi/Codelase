using Microsoft.EntityFrameworkCore;

namespace codelase.data.DatabaseContexts.AuthenticationDbContext
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