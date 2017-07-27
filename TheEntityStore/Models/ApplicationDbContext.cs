using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace TheEntityStore.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext()
            : base("TheEntityStore", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}