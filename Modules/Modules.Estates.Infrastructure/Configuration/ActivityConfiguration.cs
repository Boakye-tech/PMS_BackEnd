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

public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
{
    public void Configure(EntityTypeBuilder<Activity> builder)
    {
        builder.HasIndex(a => a.ActivityName)
               .IsUnique();

        // Configure the one-to-many relationship with ActivityType
        builder.HasMany(a => a.ActivityTypes)
               .WithOne(at => at.Activity)
               .HasForeignKey(at => at.ActivityId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
            new Activity(1, "LETTERS", "VARIOUS LETTERS ON PROPERTY" ),
            new Activity(2, "DEPOSITS", "VARIOUS CUSTOMER DEPOSITS ON PROPERTIES" )
        );

    }


}

