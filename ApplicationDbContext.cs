using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAssignment
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, UserName = "raman", Email = "raman34451@gmail.com", PhoneNumber = "34567788" },
                new User { UserId = 2, UserName = "aman", Email = "amam345@gmail.com", PhoneNumber = "456788888" },
                new User { UserId = 3, UserName = "mandeep", Email = "mandeep34565@gmail.com", PhoneNumber = "789655555" }
            );

            modelBuilder.Entity<Post>().HasData(
                new Post { PostId = 1, Title = "post", Content = "my first assignment", UserId = 1 }
            );
        }
    }

}
        
    
