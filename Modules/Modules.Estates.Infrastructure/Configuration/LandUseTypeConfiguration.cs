namespace Modules.Estates.Infrastructure.Configuration;

public class LandUseTypeConfiguration : IEntityTypeConfiguration<LandUseType>
{
    public void Configure(EntityTypeBuilder<LandUseType> builder)
    {
        builder.HasIndex(lt => new { lt.LandUseTypeInitial, lt.LandUseTypeName })
               .IsUnique(true);


        builder.HasData(
            new LandUseType(1, 1, "", "TDC BUILT HOUSES (HOS)"),
            new LandUseType(1, 2, "", "LESSEE BUILT HOUSES"),
            new LandUseType(1, 3, "", "APARTMENTS"),
            new LandUseType(1, 4, "", "HOUSES BY ESTATE DEVELOPERS"),

            new LandUseType(6, 5, "SHP", "SHOPS & OFFICES"),
            new LandUseType(6, 6, "RES", "RESTAURANTS & PUS"),
            new LandUseType(6, 7, "HTL", "GUEST HOUSE & HOTELS"),
            new LandUseType(6, 8, "PFS", "PETROL FILLING STATION"),
            new LandUseType(6, 9, "EVT", "EVENT CENTRES"),
            new LandUseType(6, 10, "CLH", "CLUB HOUSES"),
            new LandUseType(6, 11, "WHB", "WASHING BAY"),
            new LandUseType(6, 12, "CMS", "CORN MILL SITE"),
            new LandUseType(6, 13, "LIC", "LICENSE"),

            new LandUseType(9, 14, "HIA", "HEAVY INDUSTRIAL ACTIVITIES"),
            new LandUseType(9, 15, "LIA", "LIGHT INDUSTRIAL ACTIVITIES"),
            new LandUseType(9, 16, "AGR", "AGRO INDUSTRIAL ACTIVITIES"),
            new LandUseType(9, 17, "EMT", "EASEMENT"),

            new LandUseType(11, 18, "SCH", "SCHOOLS"),
            new LandUseType(11, 19, "CHU", "CHURCHES"),
            new LandUseType(11, 20, "MOS", "MOSQUES"),
            new LandUseType(11, 21, "LIB", "LIBRARY"),
            new LandUseType(11, 22, "PUB", "PUBLIC INSTITUTIONS"),
            new LandUseType(11, 23, "CLI", "CLINICS & HOSPITALS"),

            new LandUseType(12, 24, "GOC", "GOLF COURSE"),
            new LandUseType(12, 25, "PLG", "PLAYGROUND"),
            new LandUseType(12, 26, "HOR", "HORTICULTURE")

            );

    }
}

