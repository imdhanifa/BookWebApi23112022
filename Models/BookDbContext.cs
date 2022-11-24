using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookWebApi23112022.Models
{
    public partial class BookDbContext : DbContext
    {
        public BookDbContext()
        {
        }

        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBook> TblBook { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBook>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.Property(e => e.AuthorFirstName).HasMaxLength(100);

                entity.Property(e => e.AuthorLastName).HasMaxLength(100);

                entity.Property(e => e.IssueNo).HasMaxLength(10);

                entity.Property(e => e.JournalTitle).HasMaxLength(100);

                entity.Property(e => e.PageNumbers).HasMaxLength(20);

                entity.Property(e => e.PageRange).HasMaxLength(10);

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PublishDate).HasColumnType("date");

                entity.Property(e => e.Publisher).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.TitleOfContainer).HasMaxLength(100);

                entity.Property(e => e.UrlDoi)
                    .HasColumnName("URL_DOI")
                    .HasMaxLength(200);

                entity.Property(e => e.VolumeNo).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
