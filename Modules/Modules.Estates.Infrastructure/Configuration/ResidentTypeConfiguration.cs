using System;

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

