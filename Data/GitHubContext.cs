using GitHub.Domain;
using Microsoft.EntityFrameworkCore;

namespace GitHub.Data
{
    public class GitHubContext : DbContext
    {
        public GitHubContext(DbContextOptions<GitHubContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Plan> Plans { get; set; }
    }
}
