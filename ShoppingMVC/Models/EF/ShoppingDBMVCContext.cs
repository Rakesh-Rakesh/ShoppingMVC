using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ShoppingMVC.Models.EF
{
    public partial class ShoppingDBMVCContext : DbContext
    {
        public ShoppingDBMVCContext()
        {
        }

        public ShoppingDBMVCContext(DbContextOptions<ShoppingDBMVCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=PAVAN\\PAWAN;database=ShoppingDBMVC;user id=sa;password=sa@12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Products__C570593842A6A8D2");

                entity.Property(e => e.Pid).ValueGeneratedNever();

                entity.Property(e => e.Pcategory)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PCategory");

                entity.Property(e => e.PinStock).HasColumnName("PInStock");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PName");

                entity.Property(e => e.Pprice).HasColumnName("PPrice");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
