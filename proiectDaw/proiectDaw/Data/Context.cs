using Microsoft.EntityFrameworkCore;
using proiectDaw.Models;

namespace proiectDaw.Data
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }


        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // One to one User -Subscription

            builder.Entity<User>()
                .HasOne(u => u.Subscription)
                .WithOne(s => s.User)
                .HasForeignKey<Subscription>(s => s.UserId);

            // One to many Author - Books
            builder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author);

            //Many to many User - Book

            builder.Entity<UserBookRelation>()
                .HasKey(r => new { r.UserId, r.BookId });

            builder.Entity<UserBookRelation>()
                .HasOne(r => r.User)
                .WithMany(u => u.UserBookRelations)
                .HasForeignKey(r => r.UserId);

            builder.Entity<UserBookRelation>()
                .HasOne(r => r.Book)
                .WithMany(b => b.UserBookRelations)
                .HasForeignKey(r => r.BookId);


            base.OnModelCreating(builder);
        }
    }
}
