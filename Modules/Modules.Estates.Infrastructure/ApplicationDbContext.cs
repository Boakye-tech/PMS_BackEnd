// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Estates.Infrastructure;

public class ApplicationDbContext : ModuleDbContext
{
    protected override string Schema => "est";

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    //----customer related tables
    public DbSet<CustomerType> CustomerType { get; set; }
    public DbSet<Gender> Gender { get; set; }
    public DbSet<IdentificationType> IdentificationType { get; set; }
    public DbSet<Nationality> Nationality { get; set; }
    public DbSet<ResidentType> ResidentType { get; set; }
    public DbSet<SocialMedia> SocialMedia { get; set; }
    public DbSet<Title> Title { get; set; }


    //----property related tables
    public DbSet<AllocationType> AllocationType { get; set; }
    public DbSet<ApartmentTypes> ApartmentTypes { get; set; }
    public DbSet<BlockNumber> BlockNumber { get; set; }
    public DbSet<BlockSides> BlockSides { get; set; }
    public DbSet<BlockStatus> BlockStatus { get; set; }
    public DbSet<BlockTypes> BlockTypes { get; set; }
    public DbSet<BlockUnit> BlockUnit { get; set; }
    public DbSet<Facilities> Facilities { get; set; }
    public DbSet<FloorNumbering> FloorNumbering { get; set; }
    public DbSet<LandUse> LandUse { get; set; }
    public DbSet<LandUseType> LandUseType { get; set; }
    public DbSet<Locality> Locality { get; set; }
    public DbSet<PlotSize> PlotSize { get; set; }
    public DbSet<PropertyHeight> PropertyHeight { get; set; }
    public DbSet<PropertyType> PropertyType { get; set; }

    public DbSet<Activity> Activity { get; set; }
    public DbSet<ActivityType> ActivityType { get; set; }

    public DbSet<CustomerMaster> CustomerMaster { get; set; }
    public DbSet<PropertyMaster> PropertyMaster { get; set; }

    public DbSet<OwnershipType> OwnershipType { get; set; }

    public DbSet<StopDebit> StopDebit { get; set; }

    public DbSet<InterestExpressed> InterestExpressed { get; set; }

    public DbSet<ComplaintType> ComplaintType { get; set; }
    public DbSet<NatureOfComplaint> NatureOfComplaint { get; set; }
    public DbSet<Complaint> Complaints { get; set; }
    public DbSet<ComplaintHistory> ComplaintHistory { get; set; }
    public DbSet<ComplaintStatuses> ComplaintStatuses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

        //set custom schema
        modelBuilder.HasDefaultSchema("est");

        modelBuilder.Entity<PropertyMaster>()
            .HasIndex(pm => pm.PropertyNumber)
            .IsUnique(true);

        modelBuilder.Entity<CustomerMaster>()
            .HasIndex(cm => cm.CustomerCode)
            .IsUnique(true);

        modelBuilder.Entity<Complaint>()
            .HasIndex(c => c.ComplaintNumber)
            .IsUnique(true);

        modelBuilder.Entity<ComplaintStatuses>()
            .HasIndex(c => c.ComplaintStatus)
            .IsUnique(true);

        modelBuilder.Entity<ComplaintHistory>()
            .HasIndex(ch => new { ch.ComplaintNumber, ch.ComplaintStatus })
            .IsUnique(true);

        modelBuilder.Entity<CustomerMaster>().Ignore(x => x.DomainEvents);

        //modelBuilder.Entity<ApartmentTypes>

        //modelBuilder.ApplyConfiguration(new AllocationTypeConfiguration());
        //modelBuilder.ApplyConfiguration(new ApartmentTypesConfiguration());
        //modelBuilder.ApplyConfiguration(new LandUseConfiguration());
        //modelBuilder.ApplyConfiguration(new LandUseTypeConfiguration());
        //modelBuilder.ApplyConfiguration(new LocalityConfiguration());
        //modelBuilder.ApplyConfiguration(new PropertyTypeConfiguration());
        //modelBuilder.ApplyConfiguration(new ApartmentTypesConfiguration());

        //modelBuilder.ApplyConfiguration(new ActivityConfiguration());
        //modelBuilder.ApplyConfiguration(new ActivityTypeConfiguration());
        //modelBuilder.ApplyConfiguration(new ComplaintStatusConfiguration());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }

}
