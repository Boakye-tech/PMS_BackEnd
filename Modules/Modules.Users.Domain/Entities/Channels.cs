﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities
{
	public class Channels : AuditableEntity
	{
		[Key]
		[Required]
		public int ChannelId { get; set; }

        [Required]
        [StringLength(20)]
		public string? ChannelName { get; set; }

		public Channels(int channelId, string channelName)
		{
			ChannelId = channelId;
			ChannelName = channelName;
		}

		public static Channels CreateUpdate(int channelId, string channelName)
		{
            if (string.IsNullOrWhiteSpace(channelName) || channelId < 0)
            {
                throw new ArgumentException("Invalid channels data.");
            }

            if (channelId <= 0)
                throw new ArgumentException("The channel id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(channelName) || channelName.Length > 20)
                throw new ArgumentException("The channel name must not be null or exceed 20 characters.");

            return new Channels(channelId, channelName);
        }
	}

	
}

