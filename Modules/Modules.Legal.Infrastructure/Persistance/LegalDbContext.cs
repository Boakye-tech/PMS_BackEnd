// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Infrastructure/Persistance/LegalDbContext.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 5:20 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Modules.Common.Infrastructure;
using Modules.Legal.Infrastructure.Configurations;

namespace Modules.Legal.Infrastructure.Persistance
{
	public class LegalDbContext : ModuleDbContext
    {
        protected override string Schema => "leg";

        public LegalDbContext(DbContextOptions<LegalDbContext> options) : base(options)
        {

        }

        //15th Sept, 2025
        public DbSet<CaseType> CaseType { get; set; }
        public DbSet<ConsentType> ConsentType { get; set; }
        public DbSet<CourtDivisions> CourtDivisions { get; set; }
        public DbSet<Courts> Courts { get; set; }
        public DbSet<StatusTypes> StatusTypes { get; set; }
        public DbSet<TransferTypes> TransferTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            //set custom schema
            modelBuilder.HasDefaultSchema("leg");

            //modelBuilder.ApplyConfiguration(new CaseTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new ConsentTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new CourtsConfiguration());
            //modelBuilder.ApplyConfiguration(new StatusTypesConfiguration());
            //modelBuilder.ApplyConfiguration(new TransferTypesConfiguration());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

    }
}

