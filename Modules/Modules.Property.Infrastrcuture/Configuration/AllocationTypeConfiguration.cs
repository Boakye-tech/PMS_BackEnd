﻿namespace Modules.Estates.Infrastructure.Configuration;

public class AllocationTypeConfiguration : IEntityTypeConfiguration<AllocationType>
{
    public void Configure(EntityTypeBuilder<AllocationType> builder)
    {
        builder.HasIndex(at => new { at.AllocationTypeInitial, at.AllocationTypes })
               .IsUnique(true);

        builder.HasData(
            new AllocationType(1, "DTA", "DIRECT ALLOCATION" ),
            new AllocationType(2, "DTR", "DIRECT RENT" ),
            new AllocationType(3, "RGU", "REGULARIZATION" ),
            new AllocationType(4, "DPA", "DUTY POST ALLOCATION" ),
            new AllocationType(5, "TTC", "TEMA TRADITIONAL COUNCIL" ),
            new AllocationType(6, "NTC", "NUNGUA TRADITIONAL COUNCIL" ),
            new AllocationType(7, "KTC", "KPONE TRADITIONAL COUNCIL" )
            );
    }
}

