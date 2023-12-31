﻿using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DataAccess.EntiitesConfiguration
{
    public class ProductConfiguration:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder) {

            //Set Primary Key
            builder.HasKey(x => x.Id);

            //Set Property configurations
            builder.Property(x => x.Name)
                   .HasMaxLength(180)
                   .IsRequired();

            builder.Property(x => x.Description)
                   .HasMaxLength(1024);

            //Set Relationship configurations
            builder.HasOne<Category>(x => x.Category)
                   .WithMany(x => x.Products)
                   .HasForeignKey(x => x.CategoryId);





        }
    }
}
