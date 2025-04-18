﻿using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace Modules.Common.Infrastructure;

public abstract class ModuleDbContext : DbContext
{
    protected abstract string Schema { get; }
    protected ModuleDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if (!string.IsNullOrWhiteSpace(Schema))
        {
            modelBuilder.HasDefaultSchema(Schema);
        }
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }



    //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    //{
    //    return (await base.SaveChangesAsync(true, cancellationToken));
    //}
}