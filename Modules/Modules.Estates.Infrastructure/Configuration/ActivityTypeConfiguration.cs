namespace Modules.Estates.Infrastructure.Configuration;

public class ActivityTypeConfiguration : IEntityTypeConfiguration<ActivityType>
{
    public void Configure(EntityTypeBuilder<ActivityType> builder)
    {
        builder.HasIndex(l => l.ActivityTypeName)
               .IsUnique();


        builder.HasData(
            new ActivityType(1, 2, "APPLICATION LETTER", "Initial Letter" ),
            new ActivityType(1, 3, "ACCEPTANCE LETTER", "Acceptance Letter written by customer"),
            new ActivityType(1, 4, "OFFER LETTER", "Offer Letter Sent to customer"),

            new ActivityType(2, 5, "KEYS DEPOSITS", "VARIOUS CUSTOMER DEPOSITS ON PROPERTIES" ),
            new ActivityType(2, 6, "WATER DEPOSITS", "VARIOUS CUSTOMER DEPOSITS ON PROPERTIES")

        );
    }
}

