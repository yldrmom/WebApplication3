using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Controllers.ORM
{
    public class WebContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-D848M7U\\SQLEXPRESS;DataBase=WebApplication;Trusted_Connection=True;trustServerCertificate=true");
        }
        public DbSet<AdminUser> Users { get; set; }
    }
}
