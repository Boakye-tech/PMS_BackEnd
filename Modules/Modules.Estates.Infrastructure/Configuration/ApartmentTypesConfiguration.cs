// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



using System.Text.Json;
using Modules.Estates.Domain.Enums;

namespace Modules.Estates.Infrastructure.Configuration;

public class ApartmentTypesConfiguration : IEntityTypeConfiguration<ApartmentTypes>
{
    public void Configure(EntityTypeBuilder<ApartmentTypes> builder)
    {

        // Configure the Images array to be stored as JSON
        builder.Property(x => x.Images)
            .HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null!),
                v => JsonSerializer.Deserialize<string[]>(v, (JsonSerializerOptions)null!)!)
            .HasColumnType("nvarchar(max)");


        builder.HasIndex(a => a.ApartmentType).IsUnique(true);

        builder.HasData(
            new ApartmentTypes(ApartmentCategoryEnum.AFFORDABLE, 1, "STUDIO", 8000, 2, 27.43, new[] {""} ),
            new ApartmentTypes(ApartmentCategoryEnum.AFFORDABLE, 2, "ONE BEDROOM", 17000, 2, 41.12, new[] { "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Affordable1Bed.png" }),
            new ApartmentTypes(ApartmentCategoryEnum.AFFORDABLE, 3, "ONE BEDROOM (SPECIAL)", 24000, 2, 60.63, new[] { "" }),
            new ApartmentTypes(ApartmentCategoryEnum.AFFORDABLE, 4, "TWO BEDROOMS", 28000, 2, 74.80, new[]{ "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Affordable2Bed.png" }),
            new ApartmentTypes(ApartmentCategoryEnum.LUXURY, 5, "TWO BEDROOM", 197500, 2, 107.0, new[] { "" }),
            new ApartmentTypes(ApartmentCategoryEnum.LUXURY, 6, "THREE BEDROOM", 286400, 2, 218.0, new[] { "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Luxury3Bed.png" })
            );
    }
}

