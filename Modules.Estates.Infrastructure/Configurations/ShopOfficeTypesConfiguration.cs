using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.Infrastructure.Configurations
{
    public class ShopOfficeTypesConfiguration : IEntityTypeConfiguration<ShopOfficeTypes>
    {
        public void Configure(EntityTypeBuilder<ShopOfficeTypes> builder)
        {

            builder.HasKey(x => x.ShopOfficeTypeId);

            builder.Property(x => x.Code)
                .HasMaxLength(10);

            builder.Property(x => x.TypeName)
                .HasMaxLength(50);

            builder.Property(x => x.RentalCategoryId)
                .IsRequired();

            builder.Property(x => x.RentalTypeId)
                .IsRequired();

            builder.Property(x => x.Notes)
                .IsRequired()
                .HasMaxLength(100);

            // Configure the Features array to be stored as JSON
            builder.Property(x => x.Features)
                .HasConversion(
                    v => System.Text.Json.JsonSerializer.Serialize(v, (JsonSerializerOptions)null!),
                    v => System.Text.Json.JsonSerializer.Deserialize<string[]>(v, (JsonSerializerOptions)null!))!
                .HasColumnType("nvarchar(max)");
        }
    }
}