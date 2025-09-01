// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/Persistance/ApplicationDbContext.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 1:48 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http.Internal;
using Modules.Documents.Domain.Common;
using Modules.Documents.Domain.Entities;
using Modules.Documents.Infrastructure.Configuration;

namespace Modules.Documents.Infrastructure.Persistance
{
	public class ApplicationDbContext : ModuleDbContext
    {
        protected override string Schema => "doc";

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //29 Aug, 2025
        public DbSet<FormTemplates> FormTemplates { get; set; }
        public DbSet<FormFields> FormFields { get; set; }

        //30 Aug, 2025
        public DbSet<ApplicationFormSubmission> ApplicationFormSubmission { get; set; }
        public DbSet<ApplicationFormResponse> ApplicationFormResponse { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<BaseEvent>();

            //set custom schema
            modelBuilder.HasDefaultSchema("doc");



            modelBuilder.ApplyConfiguration(new FormFieldsConfiguration());
            modelBuilder.ApplyConfiguration(new FormSubmissionConfiguration());
            modelBuilder.ApplyConfiguration(new FormTemplatesConfiguration());
            modelBuilder.ApplyConfiguration(new StatusHistoryConfiguration());

        }



    }

}

