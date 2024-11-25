﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using LoadDwhVenta.DatabaseObjects.Context;
using LoadDwhVenta.DatabaseObjects.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace LoadDwhVenta.DatabaseObjects.Context.Configurations
{
    public partial class DimShipperConfiguration : IEntityTypeConfiguration<DimShipper>
    {
        public void Configure(EntityTypeBuilder<DimShipper> entity)
        {
            entity.HasKey(e => e.ShipperKey).HasName("PK__DimShipp__503F471F0871CB54");

            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
            entity.Property(e => e.ShipperName)
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DimShipper> entity);
    }
}
