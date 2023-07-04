﻿using AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Datapoint.UnitOfWork.EntityFrameworkCore;

namespace AzoresGov.Healthcare.Reimbursements.UnitOfWork.EntityTypeConfigurations
{
    public sealed class UserEntityRoleEntityTypeConfiguration : IEntityTypeConfiguration<UserEntityRoleEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntityRoleEntity> builder)
        {
            builder.Entity();

            builder.HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.HasOne(e => e.Entity)
                .WithMany()
                .HasForeignKey(e => e.EntityId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.HasOne(e => e.Role)
                .WithMany()
                .HasForeignKey(e => e.RoleId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.HasIndex(e => e.UserId);

            builder.HasIndex(e => e.EntityId);

            builder.HasIndex(e => e.RoleId);

            builder.HasAlternateKey(e => new
            {
                e.UserId,
                e.EntityId,
                e.RoleId
            });
        }
    }
}
