using ApplicationCore.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            var navigation = builder.Metadata.FindNavigation(nameof(Order.OrderItems));

            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.OwnsOne(o => o.ShipToAddress, a =>
            {
                a.WithOwner();

                a.Property(x=> x.ZipCode)
                    .HasMaxLength(18)
                    .IsRequired();

                a.Property(x => x.Street)
                    .HasMaxLength(180)
                    .IsRequired();

                a.Property(x => x.State)
                    .HasMaxLength(60);

                a.Property(x => x.Country)
                    .HasMaxLength(90)
                    .IsRequired();

                a.Property(x => x.City)
                    .HasMaxLength(100)
                    .IsRequired();
            });
        }
    }
}
