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

public class PlotTypeConfiguration: IEntityTypeConfiguration<PlotType>
{
    public void Configure(EntityTypeBuilder<PlotType> builder)
    {
        builder.HasIndex(p => p.PlotTypes)
               .IsUnique(true);

        // Configure the one-to-many relationship with currency
        builder.HasOne(p => p.Currency)
               .WithMany()
               .HasForeignKey(p => p.CurrencyId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
            new PlotType(1, "SERVICED PLOT", 24000, 2),
            new PlotType(2, "PARTIALLY SERVICED PLOT",12000, 2),
            new PlotType(3, "UNSERVICED PLOT", 15000, 1)
            );
    }
}

