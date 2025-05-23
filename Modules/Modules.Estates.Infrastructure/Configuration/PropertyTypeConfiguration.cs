﻿// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Infrastructure.Configuration;

public class PropertyTypeConfiguration: IEntityTypeConfiguration<PropertyType>
{
    public void Configure(EntityTypeBuilder<PropertyType> builder)
    {
        builder.HasIndex(p => p.PropertyTypes)
               .IsUnique(true);

        builder.HasData(
            new PropertyType(1, "SERVICED PLOT" ),
            new PropertyType(2, "PARTIALLY SERVICED PLOT" ),
            new PropertyType(3, "UNSERVICED PLOT" ),
            new PropertyType(4, "H.O.S HOUSE" ),
            new PropertyType(5, "H.O.S APARTMENT"),
            new PropertyType(6, "SHOP/OFFICE" ),
            new PropertyType(7, "RENTAL HOUSE" ),
            new PropertyType(8, "APARTMENT" )
            );
    }
}

