using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace S1.DataStore
{
    public partial class DataStoreContext : DbContext
    {
        public DataStoreContext()
        {
        }

        public DataStoreContext(DbContextOptions<DataStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<_Class> Classes { get; set; }
        public virtual DbSet<DataItem> DataItems { get; set; }
        public virtual DbSet<PresetDescriptor> PresetDescriptors { get; set; }
        public virtual DbSet<PresetLocation> PresetLocations { get; set; }
        public virtual DbSet<StoreInfo> StoreInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlite(@"");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<_Class>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("_classes");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("cid");

                entity.Property(e => e.Class).HasColumnName("class");
            });

            modelBuilder.Entity<DataItem>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("DataItem");

                entity.HasIndex(e => e.Url, "DataItem_url");

                entity.Property(e => e.Oid)
                    .ValueGeneratedNever()
                    .HasColumnName("oid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.LastUsed).HasColumnName("_lastUsed");

                entity.Property(e => e.Modified).HasColumnName("_modified");

                entity.Property(e => e.Title).HasColumnName("_title");

                entity.Property(e => e.Url).HasColumnName("_url");

                entity.Property(e => e.UseCount).HasColumnName("_useCount");
            });

            modelBuilder.Entity<PresetDescriptor>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PresetDescriptor");

                entity.HasIndex(e => e.Category, "PresetDescriptor_category");

                entity.HasIndex(e => e.ClassId, "PresetDescriptor_classID");

                entity.HasIndex(e => e.Url, "PresetDescriptor_url");

                entity.Property(e => e.Oid)
                    .ValueGeneratedNever()
                    .HasColumnName("oid");

                entity.Property(e => e.Category).HasColumnName("_category");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.ClassId).HasColumnName("_classID");

                entity.Property(e => e.Creator).HasColumnName("_creator");

                entity.Property(e => e.Data).HasColumnName("_data");

                entity.Property(e => e.Generator).HasColumnName("_generator");

                entity.Property(e => e.LastUsed).HasColumnName("_lastUsed");

                entity.Property(e => e.Modified).HasColumnName("_modified");

                entity.Property(e => e.SubFolder).HasColumnName("_subFolder");

                entity.Property(e => e.Title).HasColumnName("_title");

                entity.Property(e => e.Url).HasColumnName("_url");

                entity.Property(e => e.UseCount).HasColumnName("_useCount");

                entity.Property(e => e.Vendor).HasColumnName("_vendor");
            });

            modelBuilder.Entity<PresetLocation>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PresetLocation");

                entity.HasIndex(e => e.Url, "PresetLocation_url");

                entity.Property(e => e.Oid)
                    .ValueGeneratedNever()
                    .HasColumnName("oid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.LastUsed).HasColumnName("_lastUsed");

                entity.Property(e => e.Modified).HasColumnName("_modified");

                entity.Property(e => e.SubFolder).HasColumnName("_subFolder");

                entity.Property(e => e.Title).HasColumnName("_title");

                entity.Property(e => e.Url).HasColumnName("_url");

                entity.Property(e => e.UseCount).HasColumnName("_useCount");
            });

            modelBuilder.Entity<StoreInfo>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("StoreInfo");

                entity.Property(e => e.Oid)
                    .ValueGeneratedNever()
                    .HasColumnName("oid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Key).HasColumnName("_key");

                entity.Property(e => e.Value).HasColumnName("_value");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
