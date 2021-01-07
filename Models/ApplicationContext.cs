using Microsoft.EntityFrameworkCore;
using System;

namespace Online_book_store.Models
{
    public class ApplicationContext : DbContext
    {
        //dotnet ef migrations add nameMig
        //dotnet ef database update
        //dotnet ef database update LastGoodMigration
        //dotnet ef migrations remove
        public DbSet<Author> Authors { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

            this.Database.SetCommandTimeout(new TimeSpan(0, 3, 0));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Stage>()
            //    //.ToTable("Stage")
            //    .HasIndex(s => new { s.Num, s.CompanyID })
            //    .IsUnique()
            //    ;

        }
    }
}
