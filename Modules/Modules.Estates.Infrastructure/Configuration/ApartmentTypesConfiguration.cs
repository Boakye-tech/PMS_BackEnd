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

namespace Modules.Estates.Infrastructure.Configuration;

public class ApartmentTypesConfiguration : IEntityTypeConfiguration<ApartmentTypes>
{
    public void Configure(EntityTypeBuilder<ApartmentTypes> builder)
    {
        builder.HasIndex(a => a.ApartmentType).IsUnique(true);

        // Configure the Images array to be stored as JSON
        builder.Property(x => x.Images)
            .HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null!),
                v => JsonSerializer.Deserialize<string[]>(v, (JsonSerializerOptions)null!)!)
            .HasColumnType("nvarchar(max)");


        // Configure the one-to-many relationship with ApartmentFeatures
        builder.HasMany(a => a.ApartmentFeatures)
               .WithOne(at => at.ApartmentType)
               .HasForeignKey(at => at.ApartmentTypeId)
               .OnDelete(DeleteBehavior.Restrict);


        builder.HasData(
            new ApartmentTypes(1, 1, "STUDIO", 8000, 2, 27.43, new[] {""} ),

            new ApartmentTypes(2, 1, "ONE BEDROOM", 17000, 2, 41.123, new[] { "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Affordable1Bed.png" }),

            new ApartmentTypes(3, 1, "ONE BEDROOM (SPECIAL)", 24000, 2, 60.634, new[] { "" }),

            new ApartmentTypes(4, 1, "TWO BEDROOM", 28000, 2, 74.80, new[]{ "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Affordable2Bed.png" }),

            new ApartmentTypes(5, 2, "TWO BEDROOMS", 197500, 2, 107.0, new[] { "" }),

            new ApartmentTypes(6, 2, "THREE BEDROOMS", 286400, 2, 218.0, new[] { "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Luxury3Bed.png" })

            );
    }
}

