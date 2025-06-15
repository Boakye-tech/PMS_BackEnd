// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Infrastructure.Configuration;

public class LandUseTypeConfiguration : IEntityTypeConfiguration<LandUseType>
{
    public void Configure(EntityTypeBuilder<LandUseType> builder)
    {
        builder.HasIndex(lt => new { lt.LandUseTypeInitial, lt.LandUseTypeName })
               .IsUnique(true);


        builder.HasData(
            new LandUseType(1, 1, "RPL", "RESIDENTIAL PLOT", "Lesse Built Houses"),
            new LandUseType(1, 2, "HOS", "HOUSE OWNERSHIP SCHEME", "TDC Built Houses"),
            new LandUseType(1, 3, "LSD", "LARGE SCALE DEVELOPMENT", "Houses by Estates Developer"),
            new LandUseType(1, 4, "HSE", "HOUSE", ""),
            new LandUseType(1, 5, "FLT", "FLAT", ""),
            new LandUseType(1, 6, "HOS", "APARTMENTS", ""),

            new LandUseType(2, 7, "CPL", "COMMERCIAL PLOT", ""),
            new LandUseType(2, 8, "SHP", "SHOPS & OFFICES", ""),
            new LandUseType(2, 9, "LIC", "LICENSE", ""),
            new LandUseType(2, 10, "RSP", "RESTAURANTS & PUBS", ""),
            new LandUseType(2, 11, "HTL", "GUEST HOUSE & HOTELS", ""),
            new LandUseType(2, 12, "PFS", "PETROL FILLING STATION", ""),
            new LandUseType(2, 13, "EVC", "EVENT CENTRES", ""),
            new LandUseType(2, 14, "CLH", "CLUB HOUSES", ""),
            new LandUseType(2, 15, "WHB", "WASHING BAY", ""),
            new LandUseType(2, 16, "CMS", "CORN MILL SITE", ""),


            new LandUseType(3, 17, "IND", "INDUSTRIAL PLOT", ""),
            new LandUseType(3, 18, "HIA", "HEAVY INDUSTRIAL ACTIVITIES", ""),
            new LandUseType(3, 19, "LIA", "LIGHT INDUSTRIAL ACTIVITIES", ""),
            new LandUseType(3, 20, "AGR", "AGRO INDUSTRIAL ACTIVITIES", ""),
            new LandUseType(3, 21, "EMT", "EASEMENT", ""),

            new LandUseType(4, 22, "INS", "INSTITUTIONAL PLOT", ""),
            new LandUseType(4, 23, "SCH", "SCHOOLS", ""),
            new LandUseType(4, 24, "CHU", "CHURCHES", ""),
            new LandUseType(4, 25, "MOS", "MOSQUES", ""),
            new LandUseType(4, 26, "LIB", "LIBRARY", ""),
            new LandUseType(4, 27, "PIN", "PUBLIC INSTITUTIONS", ""),
            new LandUseType(4, 28, "CLI", "CLINICS & HOSPITALS", ""),

            new LandUseType(5, 29, "REC", "RECREATIONAL plot", ""),
            new LandUseType(5, 30, "GOC", "GOLF COURSE", ""),
            new LandUseType(5, 31, "PLG", "PLAYGROUND", ""),
            new LandUseType(5, 32, "HOR", "HORTICULTURE", "")

            );

    }
}
