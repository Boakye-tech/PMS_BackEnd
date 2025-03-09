using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Users.Domain.Entities.Menu;

namespace Modules.Users.Infrastructure.Configuration
{
	public class ChannelConfiguration : IEntityTypeConfiguration<Channels>
    {
        public void Configure(EntityTypeBuilder<Channels> builder)
        {
            builder.HasIndex(c => c.ChannelName);

            builder.HasData(
                new Channels(301, "Web"),
                new Channels(302, "Mobile")
                );
        }
    }
}

