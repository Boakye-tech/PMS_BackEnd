namespace Modules.Estates.Infrastructure.Configuration;

public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
{
    public void Configure(EntityTypeBuilder<Activity> builder)
    {
        builder.HasIndex(a => a.ActivityName)
               .IsUnique();


        builder.HasData(
            new Activity(1, "LETTERS", "VARIOUS LETTERS ON PROPERTY" ),
            new Activity(2, "DEPOSITS", "VARIOUS CUSTOMER DEPOSITS ON PROPERTIES" )
        );

    }


}

