// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/04/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Customers.Infrastructure.Persistence.EntityConfigurations
{
	public class ComplaintStatusConfiguration : IEntityTypeConfiguration<ComplaintStatuses>
    {
		
        public void Configure(EntityTypeBuilder<ComplaintStatuses> builder)
        {
            builder.HasIndex(c => c.ComplaintStatus)
                 .IsUnique();

            builder.HasData(
                new ComplaintStatuses(1, "SUBMITTED", "COMPLAINT HAS BEEN SUBMITTED BY THE CUSTOMER."),
                new ComplaintStatuses(2, "ACKNOWLEDGED", "COMPLAINT HAS BEEN ACKNOWLEDGED BY THE ORGANIZATION."),
                new ComplaintStatuses(3, "DISPATCHED", "COMPLAINT FORWARDED TO THE APPROPRIATE DEPARTMENT."),
                new ComplaintStatuses(4, "REVIEWED", "COMPLAINT HAS BEEN REVIEWED."),
                new ComplaintStatuses(5, "ASSIGNED", "COMPLAINT ASSIGNED TO A HANDLER."),
                new ComplaintStatuses(6, "IN PROGRESS", "COMPLAINT IS ACTIVELY BEING WORKED ON."),
                new ComplaintStatuses(7, "RESOLVED", "COMPLAINT HAS BEEN RESOLVED."),
                new ComplaintStatuses(8, "REOPENED", "COMPLAINT HAS BEEN REOPENED FOR FURTHER ACTION."),
                new ComplaintStatuses(9, "CLOSED", "COMPLAINT PROCESS IS COMPLETED AND CLOSED."),
                new ComplaintStatuses(10, "CANCELLED", "COMPLAINT HAS BEEN CANCELLED.")
                );
        }
    }
}

