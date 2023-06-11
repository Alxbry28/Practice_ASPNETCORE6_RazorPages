using Microsoft.EntityFrameworkCore;
using PracticeRazorPages.Models.Domain;

namespace PracticeRazorPages.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
