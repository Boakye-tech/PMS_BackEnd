using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.Infrastructure.Configurations
{
    public class ApartmentTypesConfiguration : IEntityTypeConfiguration<ApartmentTypes>
    {
        public void Configure(EntityTypeBuilder<ApartmentTypes> builder)
        {
            builder.ToTable("ApartmentTypes");

            builder.HasKey(x => x.ApartmentTypeId);

            builder.Property(x => x.ApartmentType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.SellingPrice)
                .IsRequired();

            builder.Property(x => x.CurrencyId)
                .IsRequired();

            builder.Property(x => x.FloorArea)
                .IsRequired();

            // Configure the Images array to be stored as JSON
            builder.Property(x => x.Images)
                .HasConversion(
                    v => System.Text.Json.JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => System.Text.Json.JsonSerializer.Deserialize<string[]>(v, (JsonSerializerOptions)null))
                .HasColumnType("nvarchar(max)");
        }
    }
}