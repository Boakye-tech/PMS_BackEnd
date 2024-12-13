namespace Modules.Estates.Infrastructure.Configuration;

public class PropertyTypeConfiguration: IEntityTypeConfiguration<PropertyType>
{
    public void Configure(EntityTypeBuilder<PropertyType> builder)
    {
        builder.HasIndex(p => p.PropertyTypes)
               .IsUnique(true);

        builder.HasData(
            new PropertyType(1, "SERVICED PLOT" ),
            new PropertyType(2, "PARTIALLY SERVICED PLOT" ),
            new PropertyType(3, "UNSERVICED PLOT" ),
            new PropertyType(4, "H.O.S HOUSE" ),
            new PropertyType(5, "SHOPS/OFFICES" ),
            new PropertyType(6, "RENTAL HOUSE" ),
            new PropertyType(7,"APARTMENTS" )
            );
    }
}

