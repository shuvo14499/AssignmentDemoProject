﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Assignment.Models.Write;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Assignment.DbContexts
{
    public partial class WriteDbContext : DbContext
    {
        public WriteDbContext()
        {
        }

        public WriteDbContext(DbContextOptions<WriteDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblItem> TblItem { get; set; }
        public virtual DbSet<TblPartner> TblPartner { get; set; }
        public virtual DbSet<TblPartnerType> TblPartnerType { get; set; }
        public virtual DbSet<TblPurchase> TblPurchase { get; set; }
        public virtual DbSet<TblPurchaseDetails> TblPurchaseDetails { get; set; }
        public virtual DbSet<TblSales> TblSales { get; set; }
        public virtual DbSet<TblSalesDetails> TblSalesDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
             ///#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=NASIR\\SQLEXPRESS;Initial Catalog = IBOS2;Connect Timeout=30;Encrypt=False;Trusted_Connection=True;ApplicationIntent=ReadWrite;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblItem>(entity =>
            {
                entity.HasKey(e => e.IntItemId)
                    .HasName("PK__tblItem__FA6F1B1244295990");

                entity.ToTable("tblItem");

                entity.Property(e => e.IntItemId).HasColumnName("intItemId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.NumStockQuantity)
                    .HasColumnName("numStockQuantity")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StrItemName)
                    .IsRequired()
                    .HasColumnName("strItemName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblPartner>(entity =>
            {
                entity.HasKey(e => e.IntPartnerId)
                    .HasName("PK__tblPartn__279F3038AE2F8958");

                entity.ToTable("tblPartner");

                entity.Property(e => e.IntPartnerId).HasColumnName("intPartnerId");

                entity.Property(e => e.IntPartnerTypeId).HasColumnName("intPartnerTypeId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.StrPartnerName)
                    .IsRequired()
                    .HasColumnName("strPartnerName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblPartnerType>(entity =>
            {
                entity.HasKey(e => e.IntPartnerTypeId)
                    .HasName("PK__tblPartn__3530195383757966");

                entity.ToTable("tblPartnerType");

                entity.Property(e => e.IntPartnerTypeId).HasColumnName("intPartnerTypeId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.StrPartnerTypeName)
                    .IsRequired()
                    .HasColumnName("strPartnerTypeName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblPurchase>(entity =>
            {
                entity.HasKey(e => e.IntPurchaseId)
                    .HasName("PK__tblPurch__39AFE6054CF23CB4");

                entity.ToTable("tblPurchase");

                entity.Property(e => e.IntPurchaseId).HasColumnName("intPurchaseId");

                entity.Property(e => e.DtePurchaseDate)
                    .HasColumnName("dtePurchaseDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntSupplierId).HasColumnName("intSupplierId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");
            });

            modelBuilder.Entity<TblPurchaseDetails>(entity =>
            {
                entity.HasKey(e => e.IntDetailsId)
                    .HasName("PK__tblPurch__0A1B5AF318F50D18");

                entity.ToTable("tblPurchaseDetails");

                entity.Property(e => e.IntDetailsId).HasColumnName("intDetailsId");

                entity.Property(e => e.IntItemId).HasColumnName("intItemId");

                entity.Property(e => e.IntPurchaseId).HasColumnName("intPurchaseId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.NumItemQuantity)
                    .HasColumnName("numItemQuantity")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumUnitPrice)
                    .HasColumnName("numUnitPrice")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TblSales>(entity =>
            {
                entity.HasKey(e => e.IntSalesId)
                    .HasName("PK__tblSales__754F6C55CB9873E9");

                entity.ToTable("tblSales");

                entity.Property(e => e.IntSalesId).HasColumnName("intSalesId");

                entity.Property(e => e.DteSalesDate)
                    .HasColumnName("dteSalesDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntCustomerId).HasColumnName("intCustomerId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");
            });

            modelBuilder.Entity<TblSalesDetails>(entity =>
            {
                entity.HasKey(e => e.IntDetailsId)
                    .HasName("PK__tblSales__0A1B5AF3C420CF93");

                entity.ToTable("tblSalesDetails");

                entity.Property(e => e.IntDetailsId).HasColumnName("intDetailsId");

                entity.Property(e => e.IntItemId).HasColumnName("intItemId");

                entity.Property(e => e.IntSalesId).HasColumnName("intSalesId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.NumItemQuantity)
                    .HasColumnName("numItemQuantity")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NumUnitPrice)
                    .HasColumnName("numUnitPrice")
                    .HasColumnType("numeric(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
