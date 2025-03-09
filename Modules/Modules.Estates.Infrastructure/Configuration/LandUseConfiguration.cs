namespace Modules.Estates.Infrastructure.Configuration;

public class LandUseConfiguration : IEntityTypeConfiguration<LandUse>
{
    public void Configure(EntityTypeBuilder<LandUse> builder)
    {
        builder.HasIndex(l => l.LandUseInitial)
               .IsUnique();

        builder.HasIndex(l => l.LandUseName)
               .IsUnique();


        //builder.HasData
        //        (
        //        new LandUse(1, "RPL", "RESIDENTIAL"),
        //        new LandUse(2, "MKT", "COMMERCIAL" ),
        //        new LandUse(3, "IND", "INDUSTRIAL" ),
        //        new LandUse(4, "INST","INSTITUTIONAL"),
        //        new LandUse(5, "AGR", "AGRICULTURAL"),
        //        new LandUse(6, "TRD", "TRADITIONAL"),
        //        new LandUse(7, "RE", "L/S RESIDENTIAL"),
        //        new LandUse(8, "CL", "CLINIC"),
        //        new LandUse(9, "6Z", "STAFF"),
        //        new LandUse(10, "VAR", "VARIOUS"),
        //        new LandUse(11, "HSE", "HOUSES"),
        //        new LandUse(12, "MI", "MOTORWAY INDUSTRIAL"),
        //        new LandUse(13, "REC", "RECREATIONAL")
        //        );

        builder.HasData(
            new LandUse(1, "RPL", "RESIDENTIAL" ),
            new LandUse(2, "HOS", "HOUSE OWNERSHIP SCHEME" ),
            new LandUse(3, "LSD", "LARGE SCALE DEVELOPMENT" ),
            new LandUse(4, "HSE", "HOUSE" ),
            new LandUse(5, "FLT", "FLAT" ),
            new LandUse(6, "CPL", "COMMERCIAL" ),
            new LandUse(7, "SHP", "SHOPS & OFFICES" ),
            new LandUse(8, "LIC", "LICENSE" ),
            new LandUse(9, "IND", "INDUSTRIAL" ),
            new LandUse(10, "EMT", "EASEMENT" ),
            new LandUse(11, "INS", "INSTITUTIONAL" ),
            new LandUse(12, "REC", "RECREATIONAL" )
        );
    }
}

