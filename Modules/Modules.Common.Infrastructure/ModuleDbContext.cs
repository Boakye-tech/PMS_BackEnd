// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.Reflection.Emit;
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