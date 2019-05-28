namespace WheyStore.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DamModel : DbContext
    {
        public DamModel()
            : base("name=DamModel1")
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .Property(e => e.Phonenumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.CreatedDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.ProductPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Brand>()
                .Property(e => e.ModifiedDate)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.CreatedDate)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.ModifiedDate)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CreatedDate)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ModifiedDate)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.CreatedDate)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.PromotionPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Phonenumber)
                .IsFixedLength();
        }
    }
}
