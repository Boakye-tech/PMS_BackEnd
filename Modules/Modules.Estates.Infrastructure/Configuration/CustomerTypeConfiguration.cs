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
	public class CustomerTypeConfiguration : IEntityTypeConfiguration<CustomerType>
	{
		public CustomerTypeConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<CustomerType> builder)
        {
            builder.HasIndex(a => a.CustomerTypes)
               .IsUnique();


            builder.HasData(
                new CustomerType(1, "COMPANY"),
                new CustomerType(2, "INDIVIDUAL"),
                new CustomerType(3, "JOINT-OWNERSHIP"),
                new CustomerType(4, "MULTI-OWNERSHIP"),
                new CustomerType(5, "PROSPECTIVE")
            );
        }

    }
}

