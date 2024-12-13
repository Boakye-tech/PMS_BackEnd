using System;

namespace Modules.Estates.Infrastructure.Configuration;

public class ApartmentTypesConfiguration : IEntityTypeConfiguration<ApartmentTypes>
{
    public void Configure(EntityTypeBuilder<ApartmentTypes> builder)
    {
        builder.HasIndex(a => a.ApartmentType).IsUnique(true);

        builder.HasData(
            new ApartmentTypes(1, "STUDIO", 8000, 1, 27.43),
            new ApartmentTypes(2, "ONE BEDROOM", 17000, 1, 41.12),
            new ApartmentTypes(3, "ONE BEDROOM (SPECIAL)", 24000, 1, 60.63),
            new ApartmentTypes(4, "TWO BEDROOMS", 28000, 1, 74.80)

            );
    }
}

