using System;

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

