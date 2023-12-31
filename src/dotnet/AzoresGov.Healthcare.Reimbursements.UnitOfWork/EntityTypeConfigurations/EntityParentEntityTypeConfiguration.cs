﻿using AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities;
using Datapoint.UnitOfWork.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AzoresGov.Healthcare.Reimbursements.UnitOfWork.EntityTypeConfigurations
{
    public sealed class EntityParentEntityTypeConfiguration : IEntityTypeConfiguration<EntityParentEntity>
    {
        public void Configure(EntityTypeBuilder<EntityParentEntity> builder)
        {
            builder.Entity();

            builder.HasOne(e => e.Entity)
                .WithMany()
                .HasForeignKey(e => e.EntityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.ParentEntity)
                .WithMany()
                .HasForeignKey(e => e.ParentEntityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.Level)
                .IsRequired();
        }
    }
}
