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

public class LandUseConfiguration : IEntityTypeConfiguration<LandUse>
{
    public void Configure(EntityTypeBuilder<LandUse> builder)
    {
        builder.HasIndex(l => l.LandUseInitial)
               .IsUnique();

        builder.HasIndex(l => l.LandUseName)
               .IsUnique();

        // Configure the one-to-many relationship with LandUseType
        builder.HasMany(l => l.LandUseTypes)
               .WithOne(lt => lt.LandUse)
               .HasForeignKey(lt => lt.LandUseId)
               .OnDelete(DeleteBehavior.Restrict);


        builder.HasData(
            new LandUse(1, "RES", "RESIDENTIAL USE"),
            new LandUse(2, "COM", "COMMERCIAL USE"),
            new LandUse(3, "IND", "INDUSTRIAL"),
            new LandUse(4, "INS", "INSTITUTIONAL"),
            new LandUse(5, "REC", "RECREATIONAL")
        );
    }
}

