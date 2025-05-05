// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Estates.Infrastructure.Configuration
{
	public class ResidentTypeConfiguration : IEntityTypeConfiguration<ResidentType>
	{
		public ResidentTypeConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<ResidentType> builder)
        {
            builder.HasIndex(a => a.ResidentTypes)
               .IsUnique();


            builder.HasData(
                new ResidentType(1, "EXPATRIATE"),
                new ResidentType(2, "NON-RESIDENT"),
                new ResidentType(3, "RESIDENT")
            );
        }
    }
}

