using Microsoft.AspNet.Identity.EntityFramework;

namespace _11.Blog_with_ASP.NET_MVC.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<_11.Blog_with_ASP.NET_MVC.Models.Post> Posts { get; set; }
    }
}