using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ZOI.BAL.Models
{
    public partial class Ozy_WebsiteContext : DbContext
    {
        public Ozy_WebsiteContext()
        {
        }

        public Ozy_WebsiteContext(DbContextOptions<Ozy_WebsiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Breeds> Breeds { get; set; }
        public virtual DbSet<Spices> Spices { get; set; }
        public virtual DbSet<TblBannerMasters> TblBannerMasters { get; set; }
        public virtual DbSet<TblEventMaster> TblEventMaster { get; set; }
        public virtual DbSet<TblOzyPetServices> TblOzyPetServices { get; set; }
        public virtual DbSet<TblTipsMaster> TblTipsMaster { get; set; }
        public virtual DbSet<TblUserMaster> TblUserMaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=148.72.232.167,1433;Database=Ozy_Website;Trusted_Connection=True;User ID=ozyuser;Password=Ozy@1234;;Persist Security Info=True;Integrated Security=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "ozyuser");

            modelBuilder.Entity<Breeds>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Breeds", "dbo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Image)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Spices>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Spices", "dbo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBannerMasters>(entity =>
            {
                entity.HasKey(e => e.BannerId)
                    .HasName("PK__Tbl_Bann__32E86AD14FC638FD");

                entity.ToTable("Tbl_BannerMasters");

                entity.Property(e => e.BannerImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BannerImageUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("ModifiedON")
                    .HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEventMaster>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__Tbl_Even__7944C8105F94EF3E");

                entity.ToTable("Tbl_EventMaster");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EventDescription).IsUnicode(false);

                entity.Property(e => e.EventEndDate).HasColumnType("datetime");

                entity.Property(e => e.EventImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventLocation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EventStartDate).HasColumnType("datetime");

                entity.Property(e => e.EventText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventTimeSlotFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventTimeSlotTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("ModifiedON")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOzyPetServices>(entity =>
            {
                entity.HasKey(e => e.PetServiceId)
                    .HasName("PK__Tbl_OzyP__5C16B89731198EC2");

                entity.ToTable("Tbl_OzyPetServices");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("ModifiedON")
                    .HasColumnType("datetime");

                entity.Property(e => e.PetServiceDescription).IsUnicode(false);

                entity.Property(e => e.PetServiceImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PetServiceImageUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PetServiceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PetServiceText).IsUnicode(false);
            });

            modelBuilder.Entity<TblTipsMaster>(entity =>
            {
                entity.HasKey(e => e.TipId)
                    .HasName("PK__Tbl_Tips__2DB1A1C887F54D6A");

                entity.ToTable("Tbl_TipsMaster");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("ModifiedON")
                    .HasColumnType("datetime");

                entity.Property(e => e.TipDescription).IsUnicode(false);

                entity.Property(e => e.TipText)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_UserMaster");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
