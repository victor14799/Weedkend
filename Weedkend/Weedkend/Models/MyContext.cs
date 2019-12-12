using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Weedkend.Models
{
    public partial class MyContext : DbContext
    {
        public MyContext()
        {
        }

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersDetail> OrdersDetail { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Weedkend;Trusted_Connection=False;User Id=sa;Password=trungnam");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.Property(e => e.UserName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImgAvatar).IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Account__Role__1B0907CE");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.BrandId)
                    .HasColumnName("BrandID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Datetime).HasColumnType("date");

                entity.Property(e => e.UserName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__Customer__21B6055D");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK__Orders__UserName__22AA2996");
            });

            modelBuilder.Entity<OrdersDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId });

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrdersDetail)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrdersDet__Order__2A4B4B5E");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrdersDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrdersDet__Produ__2B3F6F97");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImgUrl)
                    .IsRequired()
                    .HasColumnName("ImgURL");

                entity.Property(e => e.ProBrand)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.Category)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product__Categor__164452B1");

                entity.HasOne(d => d.ProBrandNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProBrand)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product__ProBran__15502E78");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(20);
            });
        }
    }
}
