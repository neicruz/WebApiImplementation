using WebApiImplementation.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiImplementation.Contexts
{
    public class ChapterContext:DbContext
    {
        public ChapterContext()
        {

        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {

        }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Password=1234567;Persist Security Info=True;User ID=sa;Initial Catalog=Chapter;Data Source=DESKTOP-AJNAII3\\SQLEXPRESS");
            }
        }
        public DbSet<Livro> Livros { get; set; }
    }
}
